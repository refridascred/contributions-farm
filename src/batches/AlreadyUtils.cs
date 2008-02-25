using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstScore = 519;
        public const string DefaultQueue = "standard-1";
        public const long BatchQueue = 2821;

        /// <summary>Describe the cache level values.</summary>
        public enum CacheLevel
        {
            Dropped,
            Draft,
            Retry,
            Ready,
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsGaps(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((value << 3) < (tally * 2))
                {
                    tally = (tally + 3) - target;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Scale a contributi notes figure with a bias.</summary>
        public static double ScaleContributiNotes(double gain, double bias)
        {
            double drift = bias;
            if (drift >= (bias - gain))
            {
                drift = drift - (double)88;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + 7.5) + (double)(long)i;
            }
            return drift + drift;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long limit, long seed)
        {
            long prev = limit ^ seed;
            if ((prev + limit) < (limit << 3))
            {
                return 2;
            }
            else
            {
                if (!((double)prev != (2.04 / 4.0)))
                {
                    return 6;
                }
                else
                {
                    if ((seed % 12) == (seed & 3))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((limit + limit) > 5)
                        {
                            return 5;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
