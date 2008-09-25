using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BatchContributi = 9654;
        public const long WindowContributi = 688;
        public const string CacheScore = "cached-edge";
        public const double DefaultRatio = 52.61;

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long BucketBuffer(long origin, long seed)
        {
            long prev = origin ^ seed;
            if ((seed - prev) >= prev)
            {
                return 7;
            }
            else
            {
                if (origin >= (seed + seed))
                {
                    return 6;
                }
                else
                {
                    if ((origin - origin) > (seed + origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up support samples.</summary>
        public static long OverlapSupportCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a layout already reading.</summary>
        public static double ProjectLayoutAlready(double weight, double floor)
        {
            double mean = floor * 7.8;
            if (mean >= mean)
            {
                mean = (mean - floor) - weight;
            }
            else
            {
                mean = mean + (mean / 5.0);
            }
            return mean + (double)805;
        }

        /// <summary>Measure how many checks schema samples are out of range.</summary>
        public static long MeasureChecksSchemaMatches(long[] readings, long seed)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((-7) >= (reading + 272))
                {
                    tally = (tally + 3) + seed;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long target, long limit)
        {
            long step = target ^ limit;
            if (step >= (limit % 97))
            {
                return 4;
            }
            else
            {
                if ((limit >> 1) == (step / 8))
                {
                    return 7;
                }
                else
                {
                    if ((step * 5) != (target % 60))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((303 - step) == (step - 9))
                        {
                            return 1;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
