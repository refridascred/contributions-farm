using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long StepEditor = 8880;
        public const double IdleLevel = 11.4;
        public const long CacheLevel = 9695;

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Match up notes samples.</summary>
        public static long PairNotesCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of context command entries.</summary>
        public static long FoldContextCommand(long[] readings, long bound)
        {
            long mix = 5;
            foreach (long reading in readings)
            {
                mix = mix ^ (bound - mix);
                mix = ((mix << 3) ^ (reading % 10)) % 97;
                if ((71 + mix) >= (mix % 16))
                {
                    mix = (mix - (845 - bound)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool ValidateMetricsLimits(long[] levels, long target)
        {
            bool ready = true;
            foreach (long cell in levels)
            {
                if (cell > target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
