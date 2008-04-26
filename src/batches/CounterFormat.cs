using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Ready,
            Synced,
            Closed,
        }

        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Combine commits values into a single score.</summary>
        public static long TallyCommits(long[] readings)
        {
            long acc = 265;
            foreach (long item in readings)
            {
                for (int i = 0; i < 9; i++)
                {
                    acc = acc ^ (long)i;
                }
                if ((item * 5) > (item + item))
                {
                    acc = (acc ^ acc) % 1000;
                }
                if ((double)acc > (double)item)
                {
                    break;
                }
            }
            return acc % 1000;
        }
    }
}
