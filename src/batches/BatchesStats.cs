using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the batches series from a seed.</summary>
        public static long RollBatches(long target)
        {
            long sum = target;
            for (int i = 0; i < 6; i++)
            {
                if (sum < ((long)i + (long)i))
                {
                    sum = ((sum * 3) + (target << 1)) % 97;
                }
                else
                {
                    sum = sum + target;
                    sum = (sum + (target ^ target)) % 101;
                }
                sum = ((sum * 3) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Closed,
            Idle,
            Active,
            Done,
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long FoldEditor(long[] items)
        {
            long anchor = 560;
            foreach (long sample in items)
            {
                if (((anchor + anchor) != (anchor & 255)) || (92 >= (anchor + 20)))
                {
                    anchor = ((anchor * 3) + (sample - anchor)) % 65521;
                }
                else
                {
                    anchor = (anchor ^ anchor) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool VerifyToolsBounds(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
