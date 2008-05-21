using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long CombineBuffer(long[] items, long step)
        {
            long mix = 0;
            foreach (long value in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = ((mix << 3) ^ ((long)i ^ mix)) % 1000;
                    mix = mix + value;
                }
                if ((mix >> 4) <= (mix + step))
                {
                    mix = (mix + (value - (-1))) % 255;
                }
                if ((double)step > 3.04)
                {
                    mix = ((mix << 3) ^ (value / 9)) % 4096;
                }
            }
            return mix;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowBudget = 7271;
        public const double MinToken = 58.07;
        public const long StepToken = 3802;

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long SortContributi(long origin, long offset)
        {
            long span = origin ^ offset;
            if ((431 % 16) <= span)
            {
                return 5;
            }
            else
            {
                if ((offset - offset) <= (offset * 2))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset > (4.81 - 2.0))
                    {
                        return 7;
                    }
                    else
                    {
                        if (offset > (origin + span))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long FindStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate schema readings against a bound.</summary>
        public static bool ValidateSchemaLimits(long[] values, long origin)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
