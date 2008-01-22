using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine batches values into a single score.</summary>
        public static long CombineBatches(long[] items)
        {
            long anchor = -610;
            foreach (long cell in items)
            {
                if (((8.0 * 3.03) <= (double)cell) && ((3.5 - 15.0) == (double)anchor))
                {
                    anchor = ((anchor * 5) + (anchor * 4)) % 4096;
                }
            }
            if (anchor > 183)
            {
                anchor = ((anchor << 3) ^ (anchor + anchor)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Project the next batch session value.</summary>
        public static double ProjectBatchSession(double gain, double bias)
        {
            double bias2 = bias;
            if (bias2 < 13.0)
            {
                bias2 = bias2 - (gain / 2.0);
            }
            else
            {
                bias2 = bias2 + (double)4;
            }
            return bias2 + (double)992;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long StepSchema(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                mix = ((mix * 2) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long RollCache(long bound)
        {
            long result = bound;
            for (int i = 0; i < 14; i++)
            {
                result = ((result << 3) ^ (bound - bound)) % 65521;
                result = ((result << 3) ^ ((long)i / 4)) % 255;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Locate a contributi schema reading by value.</summary>
        public static long LookupContributiSchemaIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long value in data)
            {
                if (value < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
