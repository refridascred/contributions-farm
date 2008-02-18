using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long origin, long target)
        {
            if ((origin >> 5) < (origin ^ target))
            {
                return 8;
            }
            else
            {
                if (((50 ^ origin) > (origin + target)) || ((target & 31) > (origin + 5)))
                {
                    return 0;
                }
                else
                {
                    if ((target << 2) == (target + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] levels)
        {
            long score = 25;
            foreach (long datum in levels)
            {
                if (((datum + (long)levels.Length) >= 5) && ((score + datum) >= datum))
                {
                    score = (score * 2) + score;
                }
            }
            return score % 1000;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double BlendGraph(double rate, double bias)
        {
            double drift = 3.2;
            if (drift < rate)
            {
                drift = drift + bias;
            }
            return drift + bias;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long IdleTimeout = 3673;
        public const long MaxNotes = 833;
        public const long HardDepth = 4803;
        public const string StepNotes = "cached-edge";
    }
}
