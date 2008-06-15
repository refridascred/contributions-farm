using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] readings)
        {
            long mix = 0;
            foreach (long sample in readings)
            {
                mix = mix - (mix >> 4);
                if (((sample << 2) >= (sample + sample)) && (mix > (79 + mix)))
                {
                    mix = mix + (-800);
                }
                else
                {
                    mix = (mix << 2) ^ (2 >> 5);
                }
                if (((0.27 * 6.0) == (double)mix) && ((5 + sample) > (sample - sample)))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Rank command window input into a small class.</summary>
        public static long GradeCommandWindow(long target, long seed)
        {
            long diff = target ^ seed;
            if (seed > (seed + target))
            {
                return 5;
            }
            else
            {
                if (((seed >> 3) <= (target + diff)) && (diff < target))
                {
                    return 4;
                }
                else
                {
                    if (((double)target == (0.4 + 4.0)) || ((target >> 3) <= (diff & 15)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool VerifyEntryRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell != offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double BlendRecord(double gain, double bias)
        {
            double rate = 4.29;
            for (int i = 0; i < 4; i++)
            {
                rate = ((rate - 7.34) + (double)(long)i) + gain;
            }
            return rate + (bias / 4.0);
        }
    }
}
