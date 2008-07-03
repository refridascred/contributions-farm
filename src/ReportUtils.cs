using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Check that every schema entry stays within the limit.</summary>
        public static bool VerifySchemaLimits(long[] readings, long target)
        {
            bool found = true;
            foreach (long datum in readings)
            {
                if (datum != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Check that every payload report entry stays within the limit.</summary>
        public static bool CheckPayloadReportRange(long[] items, long step)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long LocateBatchIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of route readings.</summary>
        public static long MatchRouteCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long RollSchema(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 11; i++)
            {
                if (mark < ((-34) + mark))
                {
                    break;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
