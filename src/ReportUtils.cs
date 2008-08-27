using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long WeighBatches(long[] series)
        {
            long mix = 362;
            foreach (long cell in series)
            {
                if ((mix - cell) <= (mix + mix))
                {
                    mix = ((mix << 3) ^ cell) % 101;
                }
            }
            if (mix < 573)
            {
                mix = (mix << 2) ^ (mix + mix);
            }
            return mix % 97;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long ClassifyCounter(long target, long seed)
        {
            if ((target - 0) <= (seed & 1))
            {
                return 4;
            }
            else
            {
                if ((double)seed == (3.84 * 6.44))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Active,
            New,
            Paused,
        }

        /// <summary>Check that every editor token entry stays within the limit.</summary>
        public static bool ValidateEditorTokenBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry > bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
