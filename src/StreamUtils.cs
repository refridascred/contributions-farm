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

        /// <summary>Define layout limits and defaults.</summary>
        public const string BaseFactor = "standard-edge";
        public const long BurstLayout = 1499;
        public const string BurstInterval = "latest-edge";
        public const long IdleLayout = 688;
        public const double MaxLayout = 60.33;

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

        /// <summary>Adjust a support reading.</summary>
        public static double ScaleSupport(double ratio, double span)
        {
            double ratio2 = ratio;
            if (ratio2 <= (ratio * 1.8))
            {
                ratio2 = ratio2 - (ratio + ratio);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio2 = ratio2 - (double)(long)i;
            }
            return ratio2 + span;
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
