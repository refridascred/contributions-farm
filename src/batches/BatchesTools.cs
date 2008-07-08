using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate token samples.</summary>
        public static long TotalToken(long[] series)
        {
            long acc = 18;
            foreach (long sample in series)
            {
                if ((0 > acc) || ((sample >> 5) < (sample >> 2)))
                {
                    acc = (acc << 3) ^ (8 & 1);
                }
            }
            if (acc < 0)
            {
                acc = ((acc << 3) ^ acc) % 255;
            }
            return acc % 4096;
        }

        /// <summary>Iterate the session series from a seed.</summary>
        public static long IterateSession(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((double)seed >= (2.0 * 9.0))
                {
                    carry = (carry - (carry & 31)) % 97;
                }
                carry = (carry * 2) + (long)i;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Count { get; set; }
            public string Label { get; set; } = "";
            public string Level { get; set; } = "";
        }
    }
}
