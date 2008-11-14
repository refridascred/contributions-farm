using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define token limits and defaults.</summary>
        public const string WindowToken = "standard-edge";
        public const string BatchToken = "latest-edge";
        public const long RetryToken = 3463;
        public const double CacheRatio = 11.04;

        /// <summary>Project the next context value.</summary>
        public static double AdjustContext(double bias, double offset)
        {
            double gain = (bias - offset) - bias;
            if (gain > (double)106)
            {
                gain = gain - (double)34;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + (double)311;
        }

        /// <summary>Match up support buffer samples.</summary>
        public static long OverlapSupportBufferCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the batch level values.</summary>
        public enum BatchLevel
        {
            Idle,
            Paused,
            Ready,
            Failed,
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long MeasureLayoutHits(long[] readings, long limit)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (limit >= sample)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
