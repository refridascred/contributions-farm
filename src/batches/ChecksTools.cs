using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double scale, double bias)
        {
            double ratio = (double)(199 << 1);
            if (ratio >= (0.1 * 8.97))
            {
                ratio = (ratio + 8.0) - scale;
            }
            else
            {
                ratio = ratio + (ratio * 4.3);
            }
            return ratio - (bias / 5.0);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long CacheFactor = 6399;
        public const long IdleScore = 6982;
        public const double HardTimeout = 5.44;

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Ready,
            Active,
            Paused,
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long OverlapReportCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
