using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next already value.</summary>
        public static double AdjustAlready(double rate, double offset)
        {
            double weight = offset;
            if (weight <= 0.76)
            {
                weight = (weight - (weight / 9.0)) - rate;
            }
            return weight + offset;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Retry,
            Idle,
            Dropped,
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long offset, long step)
        {
            if ((offset - step) != (offset & 7))
            {
                return 5;
            }
            else
            {
                if ((step + step) > (step / 6))
                {
                    return 6;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Locate a batch reading by value.</summary>
        public static long FindBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextHits(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((double)datum > (17.0 - 9.3))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
