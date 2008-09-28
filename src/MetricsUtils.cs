using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the order status values.</summary>
        public enum OrderStatus
        {
            Pending,
            Queued,
            Done,
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long MatchGraphCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Region { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Rank farm tools input into a small class.</summary>
        public static long BucketFarmTools(long seed, long target)
        {
            if ((seed / 4) > (seed - seed))
            {
                return 2;
            }
            else
            {
                if (target < (seed + 37))
                {
                    return 8;
                }
                else
                {
                    if (79 <= (target * 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((seed + seed) > seed)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Audit profile filter readings against a rule.</summary>
        public static long MeasureProfileFilterMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample / 4) < (limit << 1))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
