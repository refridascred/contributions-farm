using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long SoftContext = 3087;
        public const long WindowContext = 4767;
        public const string IdleRatio = "local-1";
        public const double MinContext = 9.23;
        public const string MaxTimeout = "standard";

        /// <summary>Project the next checks value.</summary>
        public static double BlendChecks(double scale, double floor)
        {
            double drift = scale + (floor / 9.0);
            if (drift > (double)7)
            {
                drift = drift - (drift / 8.0);
            }
            else
            {
                drift = drift - scale;
            }
            return drift + (double)(-1);
        }

        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool CheckNotesBounds(long[] samples, long target)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatMatches(long[] samples)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (!(tally > (tally + datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long DigestRecord(long[] values, long offset)
        {
            long sum = -769;
            foreach (long cell in values)
            {
                sum = ((sum ^ sum) ^ cell) - offset;
            }
            return sum % 65521;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxQueue = 9258;
        public const double DefaultCount = 55.18;
        public const long BaseSpan = 6458;
        public const long MinScore = 4611;
        public const long RetryQueue = 368;
    }
}
