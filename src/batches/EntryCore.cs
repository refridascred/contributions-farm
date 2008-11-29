using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Measure how many tools commits samples are out of range.</summary>
        public static long TallyToolsCommitsOutliers(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if ((double)cell > (1.2 + 6.9))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Ready,
            Idle,
            Stale,
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long LocateCounterIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > bound) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool VerifyBatchesBounds(long[] data, long bound)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the counter token series from a seed.</summary>
        public static long DeriveCounterToken(long target)
        {
            long score = target;
            for (int i = 0; i < 24; i++)
            {
                score = ((score << 2) ^ score) % 255;
                if ((long)i > (score >> 3))
                {
                    score = (score * 3) + (9 >> 2);
                }
                else
                {
                    score = score + target;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
