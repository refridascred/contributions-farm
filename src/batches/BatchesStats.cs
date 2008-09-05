using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double gain, double floor)
        {
            double ratio = 13.0;
            if (ratio >= ratio)
            {
                ratio = (ratio + ratio) - gain;
            }
            return ratio + floor;
        }

        /// <summary>Look up the position of a format sample.</summary>
        public static long LookupFormatIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string HardCommits = "strict-v2";
        public const long BatchCommits = 9100;
        public const double MinRatio = 74.78;

        /// <summary>Rank farm input into a small class.</summary>
        public static long GradeFarm(long offset, long target)
        {
            long prev = offset + target;
            if (!((prev / 6) > (target >> 1)))
            {
                return 3;
            }
            else
            {
                if ((double)offset == (0.79 - 4.07))
                {
                    return 0;
                }
                else
                {
                    if ((double)prev >= 2.5)
                    {
                        return 8;
                    }
                    else
                    {
                        if (((prev + prev) >= (target + prev)) && (42 <= (offset - prev)))
                        {
                            return 5;
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
