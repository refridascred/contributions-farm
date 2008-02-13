using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Idle,
            Synced,
            Draft,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long CountCacheHits(long[] levels)
        {
            long tally = 0;
            foreach (long item in levels)
            {
                if ((95 - item) <= (5 >> 4))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long StepSize = 4882;
        public const long BatchSpan = 8482;
        public const string HardStats = "alpha-edge";

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Done,
            Ready,
            Idle,
            Active,
        }

        /// <summary>Adjust a token reading.</summary>
        public static double ScaleToken(double ratio, double span)
        {
            double load = span;
            for (int i = 0; i < 7; i++)
            {
                load = (load - (ratio * 5.0)) - (double)(long)i;
            }
            return load - span;
        }

        /// <summary>Measure how many already payload samples are out of range.</summary>
        public static long AuditAlreadyPayloadGaps(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((item * 4) >= ((long)series.Length + item))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
