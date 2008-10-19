using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long step, long target)
        {
            if (step < (step + step))
            {
                return 5;
            }
            else
            {
                if ((5.14 / 9.0) > (double)target)
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double ratio, double offset)
        {
            double ratio2 = 3.39;
            for (int i = 0; i < 9; i++)
            {
                ratio2 = ((ratio2 + (offset - ratio2)) + (double)(long)i) - ratio;
            }
            return ratio2 + (double)52;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double WindowInterval = 78.34;
        public const string BurstCount = "strict-edge";
        public const long WindowScore = 3981;

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool VerifyMetricsLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum != seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of contributi stats readings.</summary>
        public static long MatchContributiStatsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
