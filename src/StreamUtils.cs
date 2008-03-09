using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate metric readings against a bound.</summary>
        public static bool ValidateMetricLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Project the next notes value.</summary>
        public static double BlendNotes(double rate, double bias)
        {
            double drift = rate;
            for (int i = 0; i < 4; i++)
            {
                drift = ((drift + 9.1) + (double)(long)i) + bias;
            }
            return drift - drift;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long LookupCounterIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long TotalEntry(long[] data, long floor)
        {
            long acc = 98;
            foreach (long reading in data)
            {
                if ((-4) >= (acc >> 2))
                {
                    acc = (acc ^ acc) - floor;
                }
                else
                {
                    acc = acc + (reading + acc);
                }
            }
            if (acc > (-4))
            {
                acc = (acc ^ (952 + 490)) % 101;
            }
            return acc;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool CheckClusterLimits(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the queue mode values.</summary>
        public enum QueueMode
        {
            Pending,
            Failed,
            Queued,
        }
    }
}
