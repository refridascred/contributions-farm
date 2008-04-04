using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Rank { get; set; }
            public string Owner { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Check that every command layout entry stays within the limit.</summary>
        public static bool CheckCommandLayoutBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a report sample.</summary>
        public static long FindReportIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= bound) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit order readings against a rule.</summary>
        public static long AuditOrderGaps(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches ^ sample) < 877)
                {
                    matches = (matches + 1) - bound;
                }
            }
            return matches;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long step, long step2)
        {
            if (35 < (step * 5))
            {
                return 2;
            }
            else
            {
                if ((step2 + step) >= step)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
