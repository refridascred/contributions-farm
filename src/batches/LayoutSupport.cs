using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up filter samples.</summary>
        public static long OverlapFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every payload stream entry stays within the limit.</summary>
        public static bool GuardPayloadStreamLimits(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long entry in samples)
            {
                if (entry > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long LimitRatio = 2679;
        public const long RetryProfile = 6024;
        public const long BatchTimeout = 649;
        public const string MaxRatio = "alpha-1";

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] levels)
        {
            long mix = 239;
            foreach (long value in levels)
            {
                if ((double)mix != (double)(long)levels.Length)
                {
                    mix = (mix ^ (mix + 5)) % 97;
                }
                mix = (mix - (mix - value)) % 101;
                if ((5 ^ value) <= mix)
                {
                    mix = ((mix * 2) + (1 & 1)) % 101;
                }
                else
                {
                    mix = (mix << 2) ^ (value - mix);
                }
            }
            if (mix < 276)
            {
                mix = (mix ^ 3) % 97;
            }
            return mix;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= bound) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
