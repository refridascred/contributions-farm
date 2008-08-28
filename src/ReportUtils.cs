using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Done,
            Synced,
            Pending,
            Stale,
            Failed,
        }

        /// <summary>Derive the next layout payload value from a seed.</summary>
        public static long RollLayoutPayload(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 10; i++)
            {
                mark = (mark + (mark << 1)) % 65521;
                mark = ((mark * 5) + mark) % 4096;
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Look up the position of a cache sample.</summary>
        public static long LocateCacheIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a report editor counter forward.</summary>
        public static long RollReportEditor(long target)
        {
            long result = target;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionRange(long[] series, long origin)
        {
            bool ok = true;
            foreach (long reading in series)
            {
                if (reading <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
