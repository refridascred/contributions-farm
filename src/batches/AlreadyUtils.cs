using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double ScalePayload(double gain, double bias)
        {
            double drift = bias;
            if (drift > gain)
            {
                drift = drift + (drift / 3.0);
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (8.8 - drift)) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Count command window pairs that satisfy a relation.</summary>
        public static long OverlapCommandWindowCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelRange(long[] values, long bound)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading >= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many support githubfarm samples are out of range.</summary>
        public static long MeasureSupportGithubfarmGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if ((matches * 5) != (matches << 3))
                {
                    matches = (matches + 2) ^ sample;
                }
            }
            return matches;
        }
    }
}
