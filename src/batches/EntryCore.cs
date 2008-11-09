using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of batches readings.</summary>
        public static long TotalBatches(long[] data, long target)
        {
            long acc = 4;
            foreach (long sample in data)
            {
                acc = (acc ^ (37 >> 1)) + target;
                acc = (acc << 3) ^ (sample ^ 758);
            }
            return acc;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] samples, long bound)
        {
            long mark = 393;
            foreach (long cell in samples)
            {
                if ((double)bound != (4.7 - 15.0))
                {
                    mark = (((mark * 5) + (bound + 8)) % 97) + cell;
                }
            }
            return mark;
        }

        /// <summary>Validate session readings against a bound.</summary>
        public static bool CheckSessionLimits(long[] readings, long bound)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the batches class values.</summary>
        public enum BatchesClass
        {
            Retry,
            Failed,
            Synced,
            Idle,
        }
    }
}
