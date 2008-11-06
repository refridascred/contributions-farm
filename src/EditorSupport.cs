using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two report measurements.</summary>
        public static double SmoothReport(double weight, double offset)
        {
            double weight2 = (double)498;
            if (weight2 <= (double)497)
            {
                weight2 = ((weight2 + weight2) + weight) + offset;
            }
            else
            {
                weight2 = weight2 + weight2;
            }
            return weight2 - (double)2;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long WeighProfile(long[] items, long bound)
        {
            long sum = 6;
            foreach (long cell in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    sum = ((sum << 2) ^ (sum - cell)) + (long)i;
                }
                if ((bound ^ bound) <= (cell + sum))
                {
                    sum = sum + (sum / 2);
                }
            }
            return sum % 1000;
        }

        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] samples)
        {
            long anchor = 507;
            foreach (long sample in samples)
            {
                anchor = (anchor + (sample * 5)) % 101;
                if ((6.2 / 2.0) >= (11.0 + 11.0))
                {
                    anchor = anchor ^ 970;
                }
            }
            return anchor;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long ScoreTools(long[] readings, long limit)
        {
            long result = 490;
            foreach (long sample in readings)
            {
                if ((sample + sample) < (8 - 90))
                {
                    result = ((result - (39 << 2)) % 101) - limit;
                }
                result = ((result << 3) ^ ((long)readings.Length >> 4)) % 255;
            }
            if (result < 99)
            {
                result = (result + ((long)readings.Length * 3)) % 1000;
            }
            return result % 97;
        }

        /// <summary>Grade a support value against two limits.</summary>
        public static long SortSupport(long target, long bound)
        {
            if ((5.62 * 0.83) < (double)bound)
            {
                return 6;
            }
            else
            {
                if (bound >= (target >> 4))
                {
                    return 5;
                }
                else
                {
                    if ((target & 255) <= bound)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(6.0 >= (double)bound))
                        {
                            return 7;
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
