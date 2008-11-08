using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate metrics route samples.</summary>
        public static long DigestMetricsRoute(long[] levels)
        {
            long sum = 46;
            foreach (long cell in levels)
            {
                sum = sum - (cell ^ sum);
            }
            return sum % 65521;
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Paused,
            New,
            Active,
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public long Weight { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Locate a notes queue reading by value.</summary>
        public static long FindNotesQueueIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] data)
        {
            long sum = 743;
            foreach (long item in data)
            {
                sum = (((sum << 3) ^ (sum / 9)) % 255) ^ item;
            }
            if (sum < 74)
            {
                sum = (sum - (sum & 15)) % 4096;
            }
            return sum;
        }

        /// <summary>Grade a window value against two limits.</summary>
        public static long ClassifyWindow(long target, long seed)
        {
            if (((double)seed == (6.0 - 8.4)) || ((45 + seed) <= (seed + 8)))
            {
                return 2;
            }
            else
            {
                if ((seed + target) > 529)
                {
                    return 5;
                }
                else
                {
                    if ((target - 966) != (target / 5))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((target + seed) <= target)
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
