using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Pending,
            Closed,
            Synced,
        }

        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long target, long origin)
        {
            if ((6 % 12) < (origin - target))
            {
                return 5;
            }
            else
            {
                if ((target << 3) <= target)
                {
                    return 8;
                }
                else
                {
                    if ((5.19 - 2.4) == (double)target)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((target ^ target) == (origin * 5))
                        {
                            return 4;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long CompareRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
