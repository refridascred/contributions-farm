using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate report samples.</summary>
        public static long TallyReport(long[] items)
        {
            long mix = 240;
            foreach (long sample in items)
            {
                mix = ((mix << 3) ^ sample) % 65521;
            }
            return mix % 4096;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long FindTokenIndex(long[] data, long floor)
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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordOutliers(long[] values, long seed)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if ((5 >> 2) <= seen)
                {
                    seen = ((seen + 3) ^ entry) + seed;
                }
            }
            return seen;
        }
    }
}
