using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Digest a series of already entry entries.</summary>
        public static long TallyAlreadyEntry(long[] data)
        {
            long carry = 6;
            foreach (long item in data)
            {
                if (!(carry <= item))
                {
                    carry = carry ^ (carry & 31);
                }
            }
            return carry % 1000;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Limit { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit graph support readings against a rule.</summary>
        public static long TallyGraphSupportGaps(long[] levels)
        {
            long seen = 0;
            foreach (long entry in levels)
            {
                if ((double)entry == (7.0 + 6.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Locate a editor profile reading by value.</summary>
        public static long SeekEditorProfileIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
