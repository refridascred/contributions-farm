using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define entry limits and defaults.</summary>
        public const long MinSpan = 7331;
        public const long IdleSpan = 6225;
        public const long BaseEntry = 3675;

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] items, long origin)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the tools kind values.</summary>
        public enum ToolsKind
        {
            Dropped,
            Draft,
            New,
            Pending,
            Failed,
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long RankReport(long floor, long step)
        {
            long offset = floor + step;
            if ((offset >> 1) >= (offset / 5))
            {
                return 6;
            }
            else
            {
                if ((offset & 63) <= step)
                {
                    return 2;
                }
                else
                {
                    if (floor >= step)
                    {
                        return 1;
                    }
                    else
                    {
                        if (floor < (offset ^ step))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool CheckFarmRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Match up stream samples.</summary>
        public static long MatchStreamCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
