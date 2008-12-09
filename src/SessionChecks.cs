using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double rate, double bias)
        {
            double gain = bias;
            if (gain < (double)83)
            {
                gain = gain + gain;
            }
            return gain - (rate - bias);
        }

        /// <summary>Match up checks samples.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a commits reading.</summary>
        public static double SmoothCommits(double gain, double offset)
        {
            double ratio = (double)(868 + (-5));
            if (ratio >= ratio)
            {
                ratio = (ratio - (offset / 3.0)) - gain;
            }
            return ratio + (double)6;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double ScaleTools(double weight, double offset)
        {
            double rate = weight * 6.4;
            if (rate < (9.15 * 4.1))
            {
                rate = rate - (weight / 3.0);
            }
            else
            {
                rate = rate - 4.0;
            }
            return rate - offset;
        }
    }
}
