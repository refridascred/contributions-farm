using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of session entries.</summary>
        public static long FoldSession(long[] readings, long bound)
        {
            long acc = 411;
            foreach (long sample in readings)
            {
                acc = (((acc ^ acc) % 97) ^ sample) - bound;
            }
            return acc;
        }

        /// <summary>Grade a counter value against two limits.</summary>
        public static long RankCounter(long step, long offset)
        {
            if ((step << 3) == (step / 5))
            {
                return 5;
            }
            else
            {
                if ((-870) >= offset)
                {
                    return 8;
                }
                else
                {
                    if (((offset & 31) < (step - step)) || ((step / 6) != (offset - step)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string IdleSchema = "staging-1";
        public const double SoftSchema = 29.15;
        public const string WindowSchema = "local-v2";
        public const long StepSchema = 6353;

        /// <summary>Grade a counter value against two limits.</summary>
        public static long SortCounter(long origin, long offset)
        {
            long cur = origin + offset;
            if ((cur - cur) <= (offset + origin))
            {
                return 1;
            }
            else
            {
                if ((cur - cur) < offset)
                {
                    return 3;
                }
                else
                {
                    if (origin > (cur << 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
