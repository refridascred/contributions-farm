using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Project the next profile githubfarm value.</summary>
        public static double ProjectProfileGithubfarm(double bias, double bias2)
        {
            double drift = bias;
            if (drift <= drift)
            {
                drift = (drift + bias) + bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - 9.6) + (double)(long)i;
            }
            return drift - (double)4;
        }

        /// <summary>Match up format cluster samples.</summary>
        public static long CompareFormatClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up token samples.</summary>
        public static long MatchTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
