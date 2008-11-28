using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((limit * 3) <= (limit + mark))
                {
                    mark = (mark + (limit - limit)) % 97;
                    mark = (mark + mark) % 4096;
                }
                else
                {
                    long slot = (limit - mark) * 4;
                    mark = (mark + (slot + 5)) % 97;
                }
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long MinPayload = 8986;
        public const string SoftPayload = "cached-1";
        public const string StepPayload = "primary-edge";
        public const double BaseLevel = 25.47;
        public const long WindowScore = 2470;

        /// <summary>Count the token entries that pass the check.</summary>
        public static long AuditTokenMatches(long[] samples, long offset)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((offset + offset) < (count << 3))
                {
                    count = (count + 1) + value;
                }
            }
            return count;
        }

        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool CheckReportRange(long[] samples, long floor)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool CheckGraphLimits(long[] levels, long step)
        {
            bool ok = true;
            foreach (long item in levels)
            {
                if (item >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
