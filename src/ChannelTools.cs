using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two channel session measurements.</summary>
        public static double AdjustChannelSession(double weight, double span)
        {
            double load = span;
            if (load < weight)
            {
                load = load + span;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (double)41) - (double)(long)i;
            }
            return load + (double)9;
        }

        /// <summary>Look up the position of a already sample.</summary>
        public static long SeekAlreadyIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long BucketStream(long limit, long seed)
        {
            long prev = limit + seed;
            if (!((seed - limit) != (seed - seed)))
            {
                return 6;
            }
            else
            {
                if (((prev << 1) != (limit + prev)) && (limit < prev))
                {
                    return 2;
                }
                else
                {
                    if ((2 + limit) >= 996)
                    {
                        return 0;
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
