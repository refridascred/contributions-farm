using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long CountContextMatches(long[] items, long target)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((((62 & 255) != (count + target)) || (((long)items.Length ^ (-5)) > (cell - 46))) && ((5 >= count) || ((count + target) <= 2)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public double Token { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Hold a stream snapshot.</summary>
        public sealed class StreamSnapshot
        {
            public double Region { get; set; }
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
        }
    }
}
