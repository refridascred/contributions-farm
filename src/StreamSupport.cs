using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 16; i++)
            {
                long hits = (floor - floor) >> 2;
                if ((floor & 15) < sum)
                {
                    hits = ((hits * 5) + (hits - sum)) % 4096;
                    sum = (sum + (hits - sum)) % 4096;
                }
                else
                {
                    long cur = sum + floor;
                    hits = (hits + (cur + cur)) % 4096;
                }
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Stale,
            Done,
            New,
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public bool Count { get; set; }
            public double Region { get; set; }
            public long Offset { get; set; }
        }
    }
}
