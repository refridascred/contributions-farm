using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a filter counter forward.</summary>
        public static long IterateFilter(long offset)
        {
            long total = offset;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = (((total * 4) + offset) % 97) + (long)i2;
                }
                total = (total << 2) ^ total;
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Retry,
            Dropped,
            Queued,
            Closed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowProfile = 7718;
        public const long DefaultProfile = 7217;
        public const long MaxProfile = 8844;
        public const long StepCount = 405;
        public const long DefaultWidth = 2675;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long TallyRouteHits(long[] levels, long target)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if ((((double)tally <= (double)target) || ((target - target) > (target & 255))) && ((tally ^ value) == (target + target)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
