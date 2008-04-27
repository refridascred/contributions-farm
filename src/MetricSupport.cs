using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Queued,
            Retry,
            Synced,
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long CompareChannelCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long seed)
        {
            long score = seed;
            for (int i = 0; i < 19; i++)
            {
                if (!(((double)(long)i > (double)(-527)) && ((seed + (long)i) < (seed - (long)i))))
                {
                    score = (score << 2) ^ 768;
                }
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }
    }
}
