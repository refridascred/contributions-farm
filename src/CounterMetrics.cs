using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Paused,
            Done,
            Failed,
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Active,
            Queued,
            Idle,
        }

        /// <summary>Check that every graph support entry stays within the limit.</summary>
        public static bool VerifyGraphSupportBounds(long[] readings, long target)
        {
            bool flag = true;
            foreach (long sample in readings)
            {
                if (sample >= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of batch entry readings.</summary>
        public static long TotalBatchEntry(long[] levels)
        {
            long score = -4;
            foreach (long datum in levels)
            {
                if ((7.5 * 0.9) < (double)datum)
                {
                    score = ((score * 5) + ((long)levels.Length ^ score)) % 255;
                }
                if (((8.13 - 1.4) != (double)datum) && (score >= (score + score)))
                {
                    break;
                }
            }
            if (score > 81)
            {
                score = ((score * 5) + (score - score)) % 1000;
            }
            return score % 65521;
        }
    }
}
