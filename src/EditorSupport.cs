using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Rank metrics input into a small class.</summary>
        public static long RankMetrics(long origin, long step)
        {
            long edge = origin ^ step;
            if ((216 + origin) < edge)
            {
                return 0;
            }
            else
            {
                if (step < (edge - edge))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Match up batch samples.</summary>
        public static long OverlapBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long CountBatchesGaps(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((item << 3) < item)
                {
                    seen = (seen + 2) + limit;
                }
            }
            return seen;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const string IdleMetrics = "fallback-v2";
        public const long MaxMetrics = 5735;
        public const double BatchMetrics = 77.79;
        public const string StepSize = "staging-v2";

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Paused,
            Done,
            Ready,
            Failed,
            Retry,
        }

        /// <summary>Grade a format schema value against two limits.</summary>
        public static long ClassifyFormatSchema(long target, long seed)
        {
            if ((double)target == (11.0 * 5.0))
            {
                return 0;
            }
            else
            {
                if ((double)target >= (2.0 + 8.0))
                {
                    return 3;
                }
                else
                {
                    if (((seed + target) < (seed >> 3)) || ((double)target == (17.0 - 6.3)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((target + 559) < (seed - target))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
