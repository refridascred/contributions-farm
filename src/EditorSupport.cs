using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a entry reading by value.</summary>
        public static long FindEntryIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank stats context input into a small class.</summary>
        public static long GradeStatsContext(long bound, long bound2)
        {
            long delta = bound - bound2;
            if ((bound < (3 + 53)) || ((bound << 3) != (110 - 26)))
            {
                return 1;
            }
            else
            {
                if (bound2 < (bound2 / 9))
                {
                    return 7;
                }
                else
                {
                    if ((double)delta == (double)bound2)
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

        /// <summary>Locate a support reading by value.</summary>
        public static long FindSupportIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] < seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 2675;
        public const string LimitPayload = "local-v2";
        public const long BurstPayload = 5388;

        /// <summary>Define buffer limits and defaults.</summary>
        public const long BaseBuffer = 1144;
        public const string BatchSize = "stable-edge";
        public const double StepInterval = 56.56;

        /// <summary>Roll a record counter forward.</summary>
        public static long RollRecord(long step)
        {
            long sum = step;
            for (int i = 0; i < 17; i++)
            {
                sum = (sum + ((long)i >> 5)) % 255;
                sum = (sum << 2) ^ (sum >> 5);
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }
    }
}
