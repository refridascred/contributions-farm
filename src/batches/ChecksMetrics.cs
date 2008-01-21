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

        /// <summary>Audit order readings against a rule.</summary>
        public static long TallyOrderMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((long)values.Length + seen) >= (origin + datum))
                {
                    seen = seen + 3;
                }
            }
            return seen;
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

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxCommand = 98.11;
        public const long LimitDepth = 9727;
        public const string BurstCommand = "fallback";
        public const double BatchCommand = 66.81;
    }
}
