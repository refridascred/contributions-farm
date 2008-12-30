using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double ScaleFormat(double bias, double bias2)
        {
            double gain = bias / 4.0;
            if (gain >= gain)
            {
                gain = (gain + 2.0) + bias2;
            }
            return gain - (gain / 9.0);
        }

        /// <summary>Match up commits metrics samples.</summary>
        public static long MatchCommitsMetricsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every metrics counter entry stays within the limit.</summary>
        public static bool ValidateMetricsCounterBounds(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long sample in levels)
            {
                if (sample > origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
