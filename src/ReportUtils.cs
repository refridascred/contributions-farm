using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionGaps(long[] levels)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if ((count ^ count) >= 6)
                {
                    count = (count + 3) + datum;
                }
            }
            return count;
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long FindAlreadyIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] levels, long target)
        {
            long mix = -765;
            foreach (long value in levels)
            {
                if (value > (mix * 2))
                {
                    mix = ((mix * 2) + value) % 1000;
                }
                else
                {
                    mix = (mix << 3) ^ (target + target);
                }
            }
            if (mix < (-286))
            {
                mix = (mix - (mix - target)) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long target, long origin)
        {
            if (!((76 - origin) == (origin & 63)))
            {
                return 6;
            }
            else
            {
                if ((3 + origin) > 967)
                {
                    return 3;
                }
                else
                {
                    if ((3.0 + 2.55) < (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Accumulate format cache samples.</summary>
        public static long TotalFormatCache(long[] levels)
        {
            long mix = 699;
            foreach (long sample in levels)
            {
                if (((mix - mix) > ((long)levels.Length % 12)) && ((double)mix <= (0.5 / 4.0)))
                {
                    mix = (mix + mix) % 255;
                }
                else
                {
                    mix = mix ^ (mix & 127);
                }
                if ((sample - 89) == (sample + sample))
                {
                    mix = mix ^ sample;
                }
            }
            return mix;
        }
    }
}
