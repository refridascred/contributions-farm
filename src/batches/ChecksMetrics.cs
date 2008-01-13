using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Pending,
            Draft,
            Ready,
        }

        /// <summary>Validate layout readings against a bound.</summary>
        public static bool ValidateLayoutRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a context profile sample.</summary>
        public static long FindContextProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double MaxCommand = 96.46;
        public const long WindowLevel = 3394;
        public const string LimitCommand = "open";

        /// <summary>Classify a tools token pair into a bucket.</summary>
        public static long ClassifyToolsToken(long limit, long bound)
        {
            long next = limit ^ bound;
            if ((double)next > (double)limit)
            {
                return 1;
            }
            else
            {
                if ((limit >> 4) < bound)
                {
                    return 5;
                }
                else
                {
                    if ((next + limit) < bound)
                    {
                        return 2;
                    }
                    else
                    {
                        if ((5.0 + 6.22) >= (double)bound)
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double MinRatio = 32.03;
        public const long CacheOrder = 4040;
        public const long LimitBudget = 6190;
    }
}
