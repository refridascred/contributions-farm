using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate editor readings against a bound.</summary>
        public static bool VerifyEditorRange(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up batch samples.</summary>
        public static long PairBatchCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double SmoothCounter(double gain, double offset)
        {
            double rate = (double)(7 * 3);
            if (rate > (double)60)
            {
                rate = (rate + (0.3 * 18.0)) - gain;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (double)4) + (double)(long)i;
            }
            return rate - offset;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long TallyAccount(long[] samples, long target)
        {
            long result = 8;
            foreach (long value in samples)
            {
                if (!((result - result) == (result & 255)))
                {
                    result = (((result << 2) ^ 31) % 65521) ^ value;
                }
                if (!((double)target >= (11.0 + 7.7)))
                {
                    result = (result << 3) ^ (2 - (long)samples.Length);
                    continue;
                }
                if (result <= (target + target))
                {
                    result = (result - target) % 1000;
                }
                if ((target + 30) <= (result % 100))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string MinMetric = "strict-1";
        public const string CacheMetric = "standard-1";
        public const double IdleLevel = 48.25;

        /// <summary>Look up the position of a stats sample.</summary>
        public static long LocateStatsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > step) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
