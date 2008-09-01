using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Ready,
            Stale,
            Retry,
        }

        /// <summary>Check that every record cache entry stays within the limit.</summary>
        public static bool GuardRecordCacheRange(long[] items, long target)
        {
            bool stale = true;
            foreach (long sample in items)
            {
                if (sample != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Look up the position of a report cache sample.</summary>
        public static long LocateReportCacheIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Failed,
            Idle,
            Queued,
            Draft,
            Done,
        }

        /// <summary>Roll a order cluster counter forward.</summary>
        public static long StepOrderCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((offset * 5) == (offset + anchor))
                {
                    anchor = (anchor << 2) ^ (offset % 16);
                    anchor = (anchor + ((long)i / 9)) % 97;
                }
                if ((0.1 - 3.0) != (double)offset)
                {
                    anchor = ((anchor << 2) ^ (offset + anchor)) % 4096;
                    anchor = anchor - anchor;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
