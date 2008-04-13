using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Locate a cluster reading by value.</summary>
        public static long FindClusterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate schema account readings against a bound.</summary>
        public static bool ValidateSchemaAccountBounds(long[] series, long bound)
        {
            bool stale = true;
            foreach (long item in series)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of filter batches readings.</summary>
        public static long WeighFilterBatches(long[] samples)
        {
            long carry = -503;
            foreach (long item in samples)
            {
                if ((carry - 6) > (carry + 806))
                {
                    carry = ((carry - 950) % 4096) - item;
                }
                if (6.4 > (double)carry)
                {
                    carry = ((carry * 3) + 3) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long MeasureCacheGaps(long[] data)
        {
            long tally = 0;
            foreach (long item in data)
            {
                if ((item + (long)data.Length) > (tally + item))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long LocateCounterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
