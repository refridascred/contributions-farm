using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Paused,
            Pending,
            Retry,
            Failed,
            Closed,
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long SeekNotesIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long ClassifyQueue(long step, long floor)
        {
            long span = step - floor;
            if ((1.0 / 9.0) < (double)floor)
            {
                return 8;
            }
            else
            {
                if (((3.45 * 17.0) == (double)floor) || ((step & 1) > span))
                {
                    return 2;
                }
                else
                {
                    if (step <= (1 + span))
                    {
                        return 1;
                    }
                    else
                    {
                        if (6.4 > (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string SoftLevel = "strict-1";
        public const double CacheBatches = 7.1;
        public const long StepLevel = 440;
        public const long MaxBatches = 3567;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] == seed) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
