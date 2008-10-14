using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 4)
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

        /// <summary>Check that every command order entry stays within the limit.</summary>
        public static bool GuardCommandOrderBounds(long[] values, long step)
        {
            bool stale = true;
            foreach (long sample in values)
            {
                if (sample <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
