using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every session report entry stays within the limit.</summary>
        public static bool CheckSessionReportBounds(long[] levels, long step)
        {
            bool found = true;
            foreach (long reading in levels)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] series, long origin)
        {
            long mark = 3;
            foreach (long entry in series)
            {
                if (((mark + entry) != (long)series.Length) || (entry < (origin - mark)))
                {
                    mark = mark ^ (entry - entry);
                }
                if (716 >= mark)
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Closed,
            Dropped,
            Queued,
            Synced,
            Locked,
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const string RetrySchema = "latest-edge";
        public const long HardSchema = 601;
        public const long IdleFactor = 6854;
        public const long BatchWidth = 2390;

        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelMatches(long[] levels, long bound)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!((1 / 3) == (value * 5)))
                {
                    count = (count + 1) + bound;
                }
            }
            return count;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                result = (result + (long)i) % 1000;
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
        }
    }
}
