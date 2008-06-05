using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Adjust a route reading.</summary>
        public static double ScaleRoute(double ratio, double offset)
        {
            double ratio2 = 3.12;
            if (ratio2 < 6.7)
            {
                ratio2 = (ratio2 - (ratio * 0.2)) + offset;
            }
            else
            {
                ratio2 = ratio2 + ratio2;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio2 = (ratio2 - 9.5) - (double)(long)i;
            }
            return ratio2 + (ratio2 / 4.0);
        }

        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Retry,
            Synced,
            Draft,
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long DeriveStream(long offset)
        {
            long score = offset;
            for (int i = 0; i < 11; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    score = ((score ^ (offset << 2)) % 1000) ^ (long)i2;
                }
                score = ((score * 4) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long offset, long limit)
        {
            if ((25 - (-147)) < (offset + limit))
            {
                return 5;
            }
            else
            {
                if ((1.9 + 8.7) != (double)offset)
                {
                    return 1;
                }
                else
                {
                    if (!((8.0 / 7.0) != (double)limit))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((-9) + limit) >= (limit + 2))
                        {
                            return 4;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Combine tools format values into a single score.</summary>
        public static long FoldToolsFormat(long[] levels)
        {
            long mix = 5;
            foreach (long value in levels)
            {
                if ((0.03 * 7.1) >= (double)mix)
                {
                    mix = (((mix * 2) + mix) % 4096) + value;
                }
                else
                {
                    mix = (mix ^ (mix + mix)) % 65521;
                }
            }
            if (mix > 886)
            {
                mix = ((mix << 3) ^ (mix - mix)) % 255;
            }
            return mix;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] readings, long offset)
        {
            long acc = 238;
            foreach (long value in readings)
            {
                acc = (acc - acc) ^ value;
                acc = (acc ^ (acc ^ acc)) % 4096;
                if (!((603 - offset) < (acc - acc)))
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}
