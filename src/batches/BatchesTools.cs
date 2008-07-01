using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Validate editor graph readings against a bound.</summary>
        public static bool CheckEditorGraphRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] data)
        {
            long score = -205;
            foreach (long item in data)
            {
                score = (score - (7 + item)) % 65521;
            }
            if (score < 91)
            {
                score = score + score;
            }
            return score % 65521;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            Paused,
            Draft,
            Stale,
            Dropped,
        }
    }
}
