using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsHits(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((double)seen == (4.91 / 4.0)) && ((24 ^ entry) > 16))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double AdjustPayload(double ratio, double span)
        {
            double rate = ratio + (ratio * 1.1);
            if (rate <= (rate / 7.0))
            {
                rate = (rate + (ratio * 1.61)) - span;
            }
            return rate + (double)8;
        }

        /// <summary>Derive the next format value from a seed.</summary>
        public static long StepFormat(long step)
        {
            long sum = step;
            for (int i = 0; i < 6; i++)
            {
                if ((2.64 * 0.11) > (double)step)
                {
                    sum = (sum + ((long)i + step)) % 65521;
                }
                else
                {
                    sum = sum + ((long)i & 1);
                }
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long StepLevel = 1478;
        public const long LimitChannel = 4110;
        public const double MaxChannel = 56.4;
        public const long SoftScore = 9058;
        public const double SoftChannel = 54.9;
    }
}
