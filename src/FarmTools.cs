using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long CompareBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit queue format readings against a rule.</summary>
        public static long AuditQueueFormatHits(long[] data, long target)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((reading + count) == (64 - (long)data.Length))
                {
                    count = (count + 3) + target;
                }
            }
            return count;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Retry,
            New,
            Locked,
            Active,
            Ready,
        }
    }
}
