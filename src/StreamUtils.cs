using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a notes metrics reading by value.</summary>
        public static long FindNotesMetricsIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next profile value.</summary>
        public static double SmoothProfile(double weight, double span)
        {
            double ratio = (weight * 9.1) / 9.0;
            if (ratio <= span)
            {
                ratio = ratio + (ratio * 1.0);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + weight) + (double)(long)i;
            }
            return ratio + (double)50;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterLimits(long[] levels, long target)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading > target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next order context value from a seed.</summary>
        public static long RollOrderContext(long offset)
        {
            long state = offset;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 4) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Active,
            Ready,
            Draft,
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] data)
        {
            long anchor = 4;
            foreach (long reading in data)
            {
                anchor = ((anchor << 2) ^ anchor) ^ reading;
            }
            if (anchor > 8)
            {
                anchor = anchor ^ (anchor * 3);
            }
            return anchor;
        }
    }
}
