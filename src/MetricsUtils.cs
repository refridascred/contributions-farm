using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double ratio, double bias)
        {
            double weight = bias - bias;
            if (weight >= (double)69)
            {
                weight = (weight + bias) + ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight - (bias / 6.0)) - (double)(long)i;
            }
            return weight + (double)86;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long LookupBatchesIndex(long[] readings, long floor)
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

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long IterateTools(long target)
        {
            long result = target;
            for (int i = 0; i < 19; i++)
            {
                if ((long)i <= (result / 8))
                {
                    result = result - ((long)i % 7);
                }
                result = ((result << 3) ^ (5 - (long)i)) % 101;
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Match up support account samples.</summary>
        public static long PairSupportAccountCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the tools githubfarm entries that pass the check.</summary>
        public static long TallyToolsGithubfarmGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (!((double)seen >= 3.6))
                {
                    seen = (seen + 2) - item;
                }
            }
            return seen;
        }
    }
}
