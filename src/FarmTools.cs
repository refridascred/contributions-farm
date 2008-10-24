using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate channel profile samples.</summary>
        public static long ScoreChannelProfile(long[] readings, long seed)
        {
            long total = 4;
            foreach (long reading in readings)
            {
                total = ((((total * 3) + (long)readings.Length) % 97) - reading) - seed;
            }
            if (total > 17)
            {
                total = (total ^ (total - total)) % 255;
            }
            return total;
        }

        /// <summary>Scale a window counter figure with a bias.</summary>
        public static double SmoothWindowCounter(double gain, double bias)
        {
            double rate = (double)((-5) - 0);
            return ((rate - rate) + gain) + bias;
        }

        /// <summary>Compare every pair of graph already readings.</summary>
        public static long MatchGraphAlreadyCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
