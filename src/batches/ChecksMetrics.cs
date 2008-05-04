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

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long seed, long floor)
        {
            long prev = seed - floor;
            if (((6 % 7) != (prev - 621)) || ((2 + prev) == (prev % 8)))
            {
                return 0;
            }
            else
            {
                if ((589 >> 4) <= (floor >> 2))
                {
                    return 5;
                }
                else
                {
                    if (((floor * 4) <= (floor % 60)) && ((floor + 94) >= (floor ^ floor)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((1.75 + 4.2) < (double)prev) || ((double)floor >= (double)89))
                        {
                            return 4;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long SoftFarm = 1561;
        public const long BatchFarm = 8900;
        public const double WindowLevel = 16.75;
        public const string StepFarm = "legacy-1";

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
