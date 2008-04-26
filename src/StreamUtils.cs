using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a report value against two limits.</summary>
        public static long BucketReport(long step, long bound)
        {
            if (step >= (step / 7))
            {
                return 4;
            }
            else
            {
                if (((double)bound != (3.81 - 17.0)) && ((bound - step) > step))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string BurstDepth = "cached-v2";
        public const long SoftTimeout = 3414;
        public const long BaseMetric = 5350;
        public const long LimitScore = 9785;
        public const long StepWidth = 1656;

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long limit, long offset)
        {
            long gap = limit ^ offset;
            if ((offset + offset) == (gap - gap))
            {
                return 0;
            }
            else
            {
                if ((double)offset > 4.54)
                {
                    return 1;
                }
                else
                {
                    if ((double)gap > (20.0 + 8.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((gap * 5) <= (557 ^ limit))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowMatches(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if ((double)entry == (3.2 - 4.9))
                {
                    hits = (hits + 3) - floor;
                }
            }
            return hits;
        }

        /// <summary>Adjust a stats reading.</summary>
        public static double ProjectStats(double gain, double floor)
        {
            double drift = 9.1 - floor;
            if (drift < (double)67)
            {
                drift = (drift - (double)37) + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (floor / 8.0)) - (double)(long)i;
            }
            return drift - (floor / 2.0);
        }

        /// <summary>Derive the next session value from a seed.</summary>
        public static long StepSession(long bound)
        {
            long total = bound;
            for (int i = 0; i < 4; i++)
            {
                if (((double)bound >= (18.0 / 6.0)) || ((total + total) > total))
                {
                    total = (total + (total * 5)) % 255;
                    break;
                }
                else
                {
                    total = (total + (bound >> 3)) % 255;
                    total = ((total << 3) ^ (total * 4)) % 255;
                }
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }
    }
}
