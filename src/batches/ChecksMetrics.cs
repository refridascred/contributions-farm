using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many order samples are out of range.</summary>
        public static long AuditOrderMatches(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)matches != (3.86 / 6.0))
                {
                    matches = (matches + 1) + cell;
                }
            }
            return matches;
        }

        /// <summary>Rank report profile input into a small class.</summary>
        public static long SortReportProfile(long limit, long seed)
        {
            long diff = limit ^ seed;
            if ((seed + seed) >= (205 ^ limit))
            {
                return 3;
            }
            else
            {
                if (761 < diff)
                {
                    return 6;
                }
                else
                {
                    if (2 < (limit ^ limit))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((diff + seed) > (seed + limit)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsBounds(long[] values, long step)
        {
            bool valid = true;
            foreach (long item in values)
            {
                if (item != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first session counter entry that matches the target.</summary>
        public static long LocateSessionCounterIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 4626;
        public const long LimitLevel = 3867;
        public const double MaxToken = 81.49;
        public const long RetrySize = 7776;
        public const long BurstToken = 8287;

        /// <summary>Define batch limits and defaults.</summary>
        public const double StepBatch = 52.89;
        public const long IdleFactor = 1082;
        public const string BurstInterval = "fallback-edge";
    }
}
