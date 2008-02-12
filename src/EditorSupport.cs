using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next tools value from a seed.</summary>
        public static long RollTools(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                sum = sum + (3 >> 3);
                sum = ((sum * 2) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 3645;
        public const double BurstStats = 13.55;
        public const double WindowStats = 52.86;
        public const long BurstInterval = 8449;

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Closed,
            Pending,
            Locked,
            Done,
            Failed,
        }

        /// <summary>Blend two contributi already measurements.</summary>
        public static double SmoothContributiAlready(double weight, double floor)
        {
            double weight2 = (floor - floor) / 4.0;
            return weight2 + (weight + weight);
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long offset, long floor)
        {
            if ((double)offset > (double)floor)
            {
                return 5;
            }
            else
            {
                if (offset < floor)
                {
                    return 4;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long SortEntry(long seed, long seed2)
        {
            long offset = seed - seed2;
            if (seed2 <= (seed2 << 2))
            {
                return 8;
            }
            else
            {
                if ((seed2 << 3) > offset)
                {
                    return 0;
                }
                else
                {
                    if ((offset + seed2) > seed)
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)739 <= (double)seed2)
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
