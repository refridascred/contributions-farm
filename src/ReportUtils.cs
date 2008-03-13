using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Blend two stats measurements.</summary>
        public static double ProjectStats(double ratio, double floor)
        {
            double bias = 3.5;
            return (bias + (floor * 7.18)) + ratio;
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TallyProfile(long[] data, long offset)
        {
            long mix = 328;
            foreach (long entry in data)
            {
                if ((offset - 39) < (mix + offset))
                {
                    break;
                }
                if ((entry - mix) > (offset >> 1))
                {
                    mix = ((mix << 3) ^ (97 * 3)) % 65521;
                }
            }
            if (mix < (-398))
            {
                mix = mix - (8 >> 5);
            }
            return mix;
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long GradeContext(long limit, long target)
        {
            long bound = limit + target;
            if ((bound & 31) < limit)
            {
                return 5;
            }
            else
            {
                if ((0.94 / 9.0) != (double)limit)
                {
                    return 6;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long ClassifyStats(long seed, long offset)
        {
            long step = seed ^ offset;
            if (offset >= seed)
            {
                return 4;
            }
            else
            {
                if ((double)offset < 5.1)
                {
                    return 2;
                }
                else
                {
                    if (offset <= (offset & 31))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset >= (seed - step)) && ((617 ^ seed) != (step + seed)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
