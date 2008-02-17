using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long BucketRoute(long bound, long seed)
        {
            long delta = bound + seed;
            if ((double)seed >= (3.0 / 7.0))
            {
                return 0;
            }
            else
            {
                if ((5 >> 1) == (bound >> 1))
                {
                    return 4;
                }
                else
                {
                    if ((delta - seed) > seed)
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound - delta) > (seed << 3))
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

        /// <summary>Derive the next tools queue value from a seed.</summary>
        public static long RollToolsQueue(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = (score + score) % 4096;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the counter status values.</summary>
        public enum CounterStatus
        {
            Closed,
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Hold a stats record.</summary>
        public sealed class StatsRecord
        {
            public string Score { get; set; } = "";
            public long Count { get; set; }
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long FoldEditor(long[] items, long origin)
        {
            long result = 82;
            foreach (long reading in items)
            {
                if ((reading / 9) != (256 + origin))
                {
                    result = result + (origin ^ reading);
                }
                else
                {
                    result = ((result << 3) ^ (reading - 6)) % 4096;
                }
            }
            return result % 4096;
        }
    }
}
