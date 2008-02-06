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

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long GradeFarm(long floor, long limit)
        {
            if ((double)81 > (double)floor)
            {
                return 2;
            }
            else
            {
                if ((limit > (floor ^ floor)) && ((limit * 3) < (limit % 12)))
                {
                    return 5;
                }
                else
                {
                    if ((limit << 3) <= (floor + 767))
                    {
                        return 8;
                    }
                    else
                    {
                        if (!((double)floor <= 2.99))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public string Token { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
