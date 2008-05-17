using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Active,
            Draft,
            Synced,
            Stale,
            Ready,
        }

        /// <summary>Project the next context session value.</summary>
        public static double ProjectContextSession(double weight, double span)
        {
            double weight2 = weight + (span - span);
            for (int i = 0; i < 6; i++)
            {
                weight2 = (weight2 - (double)46) - (double)(long)i;
            }
            return weight2 + 9.0;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long SortChannel(long seed, long origin)
        {
            long cur = seed - origin;
            if ((origin & 1) > cur)
            {
                return 4;
            }
            else
            {
                if ((-93) > (seed * 2))
                {
                    return 3;
                }
                else
                {
                    if ((origin / 5) < (seed - seed))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public double Limit { get; set; }
        }
    }
}
