using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] < limit) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Retry,
            Active,
            New,
            Dropped,
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((5.84 + 12.0) != (double)value)
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public bool Mode { get; set; }
            public long Owner { get; set; }
        }
    }
}
