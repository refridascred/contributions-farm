using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of layout readings.</summary>
        public static long MatchLayoutCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double ProjectFarm(double rate, double offset)
        {
            double drift = 1.0 / 5.0;
            if (drift <= (drift / 2.0))
            {
                drift = drift + drift;
            }
            else
            {
                drift = drift + (drift + offset);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - rate) + (double)(long)i;
            }
            return drift - (drift * 12.0);
        }

        /// <summary>Describe the already status values.</summary>
        public enum AlreadyStatus
        {
            Pending,
            Active,
            Idle,
        }
    }
}
