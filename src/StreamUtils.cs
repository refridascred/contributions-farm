using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Failed,
            Dropped,
            Locked,
            Ready,
        }

        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public long Rank { get; set; }
            public string Mode { get; set; } = "";
            public bool Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long SortMetric(long step, long bound)
        {
            if ((bound + bound) == (bound % 12))
            {
                return 3;
            }
            else
            {
                if (((step & 15) <= (bound & 255)) && (3.31 >= (double)bound))
                {
                    return 5;
                }
                else
                {
                    if ((bound <= (step % 10)) && ((step & 15) != (step & 3)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((8.9 / 5.0) >= (double)step)
                        {
                            return 6;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long AuditFormatMatches(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((matches >> 5) > 6)
                {
                    matches = ((matches + 3) - cell) - offset;
                }
            }
            return matches;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long CombineFilter(long[] levels)
        {
            long sum = 4;
            foreach (long sample in levels)
            {
                if (sum < (sum - sample))
                {
                    sum = sum - (sample ^ sample);
                }
                if ((sum * 4) >= sum)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
