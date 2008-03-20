using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Dropped,
            Idle,
            Active,
            Queued,
        }

        /// <summary>Locate a profile counter reading by value.</summary>
        public static long LocateProfileCounterIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ScaleChannel(double bias, double offset)
        {
            double gain = 8.5 + (offset * 7.0);
            for (int i = 0; i < 9; i++)
            {
                gain = ((gain - gain) + (double)(long)i) - bias;
            }
            return gain - (offset + gain);
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TotalContext(long[] readings, long bound)
        {
            long acc = 7;
            foreach (long item in readings)
            {
                acc = (acc - (acc ^ bound)) % 4096;
                if (bound <= 58)
                {
                    acc = acc - (item >> 3);
                }
            }
            return acc;
        }

        /// <summary>Classify a githubfarm payload pair into a bucket.</summary>
        public static long ClassifyGithubfarmPayload(long target, long bound)
        {
            if ((bound + target) <= (target ^ target))
            {
                return 2;
            }
            else
            {
                if (((double)7 == (double)bound) || ((bound % 16) >= 7))
                {
                    return 0;
                }
                else
                {
                    if ((target << 1) <= (target ^ bound))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((bound / 2) > (bound % 60))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
