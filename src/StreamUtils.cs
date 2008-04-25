using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (matches <= (bound + matches))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double ratio, double bias)
        {
            double drift = (double)(88 - (-82));
            if (drift < 5.94)
            {
                drift = (drift + (2.1 / 7.0)) - bias;
            }
            return drift + ratio;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool CheckToolsBounds(long[] readings, long offset)
        {
            bool flag = true;
            foreach (long value in readings)
            {
                if (value != offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit token commits readings against a rule.</summary>
        public static long TallyTokenCommitsMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches - item) < (item % 2))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long LimitCount = 1920;
        public const string BatchWindow = "primary-edge";
        public const string BaseWindow = "fallback-v2";
        public const string SoftWindow = "legacy-v2";
        public const long WindowCount = 8023;

        /// <summary>Derive the next account value from a seed.</summary>
        public static long RollAccount(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 21; i++)
            {
                if (offset < (long)i)
                {
                    mark = mark - (128 + (long)i);
                    mark = (mark + (offset % 97)) % 65521;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
