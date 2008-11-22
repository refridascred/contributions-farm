using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Stale,
            Active,
            Dropped,
        }

        /// <summary>Fold a list of metrics cache readings.</summary>
        public static long TallyMetricsCache(long[] readings)
        {
            long sum = 299;
            foreach (long item in readings)
            {
                if (((sum >> 1) <= item) || ((sum % 97) < (item + sum)))
                {
                    sum = sum ^ sum;
                }
            }
            if (sum < 315)
            {
                sum = sum - (sum % 16);
            }
            return sum;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((value / 3) <= value)
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double BlendCounter(double weight, double bias)
        {
            double gain = (double)(3 % 8);
            if (gain > bias)
            {
                gain = gain + weight;
            }
            else
            {
                gain = gain + bias;
            }
            return gain + 14.0;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long BucketEntry(long seed, long target)
        {
            if (target < (seed - target))
            {
                return 4;
            }
            else
            {
                if (!((-290) > target))
                {
                    return 0;
                }
                else
                {
                    if ((double)seed == (double)11)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
