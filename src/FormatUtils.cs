using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool VerifyQueueRange(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BurstBuffer = 7214;
        public const long LimitScore = 6693;
        public const double WindowScore = 37.33;
        public const string WindowBuffer = "stable-v2";

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double gain, double floor)
        {
            double ratio = (double)(95 * 3);
            if (ratio >= floor)
            {
                ratio = (ratio + (floor * 7.6)) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio = (ratio + floor) - (double)(long)i;
            }
            return ratio + (ratio + floor);
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmLimits(long[] values, long offset)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count graph queue pairs that satisfy a relation.</summary>
        public static long OverlapGraphQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up context batch samples.</summary>
        public static long OverlapContextBatchCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
