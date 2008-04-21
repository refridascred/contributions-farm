using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Validate stream readings against a bound.</summary>
        public static bool CheckStreamLimits(long[] values, long bound)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] data, long target)
        {
            long total = 70;
            foreach (long entry in data)
            {
                if (!((total - entry) > (target - target)))
                {
                    total = (total * 5) + entry;
                }
            }
            return total;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long TallyRecordGaps(long[] data)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (hits <= (reading / 9))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
