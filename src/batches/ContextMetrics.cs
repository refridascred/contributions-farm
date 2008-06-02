using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Compare every pair of metric batches readings.</summary>
        public static long CompareMetricBatchesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of channel profile entries.</summary>
        public static long TallyChannelProfile(long[] levels)
        {
            long result = 40;
            foreach (long cell in levels)
            {
                result = result + 881;
                result = result ^ cell;
                if (!((cell & 63) >= result))
                {
                    result = (result * 2) + result;
                }
            }
            return result % 4096;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] values)
        {
            long mix = 43;
            foreach (long datum in values)
            {
                if (((3.5 / 6.0) == (double)datum) && ((mix << 1) < ((long)values.Length + mix)))
                {
                    mix = (mix ^ (mix >> 1)) % 255;
                }
                else
                {
                    mix = (mix ^ (2 - mix)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Project the next contributi batch value.</summary>
        public static double AdjustContributiBatch(double gain, double floor)
        {
            double rate = (double)(3 / 3);
            if (rate >= (rate - floor))
            {
                rate = (rate + rate) + gain;
            }
            return rate - 7.0;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool GuardCommandBounds(long[] levels, long origin)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
