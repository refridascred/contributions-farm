using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordLimits(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long RankContext(long origin, long offset)
        {
            if ((origin % 5) == (origin - 55))
            {
                return 5;
            }
            else
            {
                if (((-24) - 4) != ((-27) ^ origin))
                {
                    return 0;
                }
                else
                {
                    if (((-18) < (48 + offset)) && ((double)offset < (6.5 - 3.5)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public double Score { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Combine contributi notes values into a single score.</summary>
        public static long CombineContributiNotes(long[] series)
        {
            long result = -268;
            foreach (long item in series)
            {
                for (int i = 0; i < 10; i++)
                {
                    result = ((result * 2) + (result - item)) - (long)i;
                }
                if (((14 * 4) > (72 - item)) || ((item % 97) <= (item + item)))
                {
                    result = (result << 2) ^ (result / 8);
                }
            }
            return result;
        }

        /// <summary>Grade a context value against two limits.</summary>
        public static long BucketContext(long bound, long step)
        {
            long step2 = bound ^ step;
            if ((step * 4) < (step & 15))
            {
                return 1;
            }
            else
            {
                if (((6.0 + 5.9) < (double)step) || ((double)step2 != (3.5 * 1.7)))
                {
                    return 8;
                }
                else
                {
                    if ((step % 64) >= (step2 / 8))
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)step <= (double)step2) || ((2.66 + 0.73) >= (double)bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next session schema value from a seed.</summary>
        public static long RollSessionSchema(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 18; i++)
            {
                if ((long)i > (seed - mix))
                {
                    mix = ((mix << 3) ^ (mix << 2)) % 97;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
