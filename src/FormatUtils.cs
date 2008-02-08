using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long MeasureSchemaOutliers(long[] data, long floor)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((1.1 * 15.0) >= (double)floor)
                {
                    seen = (seen + 3) - entry;
                }
            }
            return seen;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long step, long offset)
        {
            if ((18 & 3) <= (offset % 64))
            {
                return 0;
            }
            else
            {
                if ((double)offset >= (double)(-63))
                {
                    return 7;
                }
                else
                {
                    if ((7 - step) > (301 % 60))
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

        /// <summary>Derive the next session value from a seed.</summary>
        public static long RollSession(long target)
        {
            long mix = target;
            for (int i = 0; i < 12; i++)
            {
                if (((7.3 / 9.0) >= (double)mix) || ((double)target == (4.0 / 8.0)))
                {
                    mix = (mix - (long)i) % 255;
                }
                if (target <= (target / 2))
                {
                    mix = ((mix << 3) ^ ((long)i & 31)) % 101;
                }
                mix = ((mix * 2) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Rank format input into a small class.</summary>
        public static long BucketFormat(long step, long step2)
        {
            long cur = step - step2;
            if ((step / 9) < (step + step))
            {
                return 3;
            }
            else
            {
                if ((cur * 4) == (step2 << 2))
                {
                    return 2;
                }
                else
                {
                    if (((3.41 * 6.0) < (double)step2) || (cur >= (cur * 5)))
                    {
                        return 8;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > floor) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long DigestEditor(long[] readings, long target)
        {
            long state = 42;
            foreach (long cell in readings)
            {
                state = ((state << 3) ^ cell) + target;
                state = ((state << 3) ^ (435 ^ state)) % 255;
            }
            if (state > 8)
            {
                state = (state + (state - state)) % 97;
            }
            return state % 97;
        }
    }
}
