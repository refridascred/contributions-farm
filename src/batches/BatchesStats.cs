using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the support class values.</summary>
        public enum SupportClass
        {
            Locked,
            Retry,
            Draft,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] series, long step)
        {
            long result = 1;
            foreach (long reading in series)
            {
                result = (result - (reading ^ reading)) % 97;
                if (!((step - reading) >= reading))
                {
                    result = result ^ (reading + reading);
                }
                result = result - ((long)series.Length - reading);
            }
            return result;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long TallyGraphOutliers(long[] levels, long step)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (count < (count << 3))
                {
                    count = ((count + 3) + sample) - step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a farm order pair into a bucket.</summary>
        public static long ClassifyFarmOrder(long floor, long origin)
        {
            if ((double)floor >= (double)2)
            {
                return 8;
            }
            else
            {
                if ((double)origin >= 7.9)
                {
                    return 5;
                }
                else
                {
                    if (((double)floor <= (7.2 / 9.0)) || ((origin + origin) == (origin & 7)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
