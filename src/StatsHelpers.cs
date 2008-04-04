using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a order figure with a bias.</summary>
        public static double ScaleOrder(double gain, double span)
        {
            double ratio = span;
            if (ratio <= (ratio / 9.0))
            {
                ratio = ratio + (ratio + gain);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - (ratio / 5.0)) + (double)(long)i;
            }
            return ratio - gain;
        }

        /// <summary>Match up schema githubfarm samples.</summary>
        public static long OverlapSchemaGithubfarmCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a graph githubfarm value against two limits.</summary>
        public static long SortGraphGithubfarm(long bound, long floor)
        {
            if (((floor - bound) <= (floor / 6)) && ((floor - 844) < (2 - 394)))
            {
                return 2;
            }
            else
            {
                if (((5.6 - 3.0) > (double)floor) || ((2.0 * 0.76) <= (double)floor))
                {
                    return 6;
                }
                else
                {
                    if ((floor < (floor + floor)) || ((bound & 255) < bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)(-95) < (double)floor)
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double SoftWindow = 90.28;
        public const string BatchWindow = "local-1";
        public const double IdleWindow = 22.77;

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Paused,
            Closed,
            Ready,
        }
    }
}
