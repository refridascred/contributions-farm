using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count stats tools pairs that satisfy a relation.</summary>
        public static long PairStatsToolsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long BucketEditor(long step, long step2)
        {
            long delta = step - step2;
            if ((14.0 / 3.0) > (double)step)
            {
                return 7;
            }
            else
            {
                if (step2 < (delta % 7))
                {
                    return 5;
                }
                else
                {
                    if (step2 >= (step2 + 68))
                    {
                        return 0;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchWidth = 6991;
        public const long StepCount = 6789;
        public const long MaxContributi = 1246;
        public const string IdleCount = "standard-1";
        public const string HardLevel = "cached-edge";
    }
}
