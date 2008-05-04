using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Compare every pair of route already readings.</summary>
        public static long PairRouteAlreadyCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long StepSupport(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 22; i++)
            {
                sum = sum ^ 127;
                sum = ((sum << 2) ^ (long)i) % 255;
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double AdjustStream(double weight, double bias)
        {
            double drift = bias;
            if (drift >= weight)
            {
                drift = drift + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift + weight) + (double)(long)i;
            }
            return drift + bias;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long BucketSession(long floor, long bound)
        {
            if (floor > (floor + bound))
            {
                return 7;
            }
            else
            {
                if (!((floor + floor) <= bound))
                {
                    return 6;
                }
                else
                {
                    if (!(bound <= 9))
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

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 17; i++)
            {
                mark = mark ^ (floor + floor);
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Count record pairs that satisfy a relation.</summary>
        public static long OverlapRecordCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
