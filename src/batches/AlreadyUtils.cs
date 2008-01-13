using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define graph limits and defaults.</summary>
        public const long BaseScore = 7319;
        public const long IdleGraph = 8137;
        public const long WindowGraph = 365;
        public const double MaxSpan = 75.73;

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public double Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Find the first metrics record entry that matches the target.</summary>
        public static long FindMetricsRecordIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long SortRecord(long origin, long step)
        {
            if ((5.03 + 0.8) >= (double)step)
            {
                return 1;
            }
            else
            {
                if (((step - step) <= origin) && ((double)origin <= 1.6))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin >= (4.55 + 5.22))
                    {
                        return 4;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] values, long seed)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
