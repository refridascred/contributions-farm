using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate payload metrics readings against a bound.</summary>
        public static bool VerifyPayloadMetricsBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BatchFactor = 14.18;
        public const long LimitTimeout = 7077;
        public const double DefaultFormat = 38.42;
        public const long RetryFormat = 5247;

        /// <summary>Match up cluster samples.</summary>
        public static long MatchClusterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the schema entries that pass the check.</summary>
        public static long TallySchemaGaps(long[] items, long target)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((target + seen) == ((-933) * 2))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long SortToken(long offset, long floor)
        {
            long prev = offset ^ floor;
            if ((prev >> 2) <= floor)
            {
                return 5;
            }
            else
            {
                if ((prev + prev) == (offset ^ offset))
                {
                    return 3;
                }
                else
                {
                    if ((offset - floor) < floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((prev >> 5) < (floor << 3))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
