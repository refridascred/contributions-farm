using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Project the next editor value.</summary>
        public static double ProjectEditor(double rate, double bias)
        {
            double rate2 = bias / 9.0;
            if (rate2 < 20.0)
            {
                rate2 = rate2 - (rate / 9.0);
            }
            return rate2 + (bias / 4.0);
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Dropped,
            Retry,
            Queued,
        }

        /// <summary>Rank queue editor input into a small class.</summary>
        public static long ClassifyQueueEditor(long target, long offset)
        {
            if ((double)offset == (5.0 + 0.72))
            {
                return 6;
            }
            else
            {
                if ((target << 2) >= 6)
                {
                    return 7;
                }
                else
                {
                    if ((target / 5) < ((-577) + target))
                    {
                        return 3;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long SeekFarmIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two metric measurements.</summary>
        public static double SmoothMetric(double ratio, double span)
        {
            double ratio2 = span;
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + ratio) + (double)(long)i;
            }
            return ratio2 - (double)894;
        }
    }
}
