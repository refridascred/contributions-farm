using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine cluster profile values into a single score.</summary>
        public static long DigestClusterProfile(long[] items, long bound)
        {
            long sum = 20;
            foreach (long value in items)
            {
                sum = ((sum ^ (value - sum)) % 1000) - bound;
            }
            return sum;
        }

        /// <summary>Hold a filter entry.</summary>
        public sealed class FilterEntry
        {
            public long Ratio { get; set; }
            public long Mode { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Ready,
            New,
            Done,
            Active,
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long origin, long floor)
        {
            long diff = origin ^ floor;
            if (((floor << 2) > (diff + origin)) && ((0.02 * 5.5) >= (double)origin))
            {
                return 7;
            }
            else
            {
                if ((origin % 5) >= (floor + 3))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
