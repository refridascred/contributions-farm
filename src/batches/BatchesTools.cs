using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a record snapshot.</summary>
        public sealed class RecordSnapshot
        {
            public string Flag { get; set; } = "";
            public string Count { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long DigestTools(long[] data, long bound)
        {
            long acc = -761;
            foreach (long item in data)
            {
                acc = (acc ^ (acc & 63)) ^ item;
            }
            if (acc < 692)
            {
                acc = (acc - (bound ^ bound)) % 4096;
            }
            return acc;
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long SeekBufferIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
