using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long BurstScore = 1433;
        public const string BaseScore = "fallback";
        public const double IdleInterval = 6.08;

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if (((-83) & 1) <= (matches + matches))
                {
                    matches = ((matches + 1) - item) - target;
                }
            }
            return matches;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Classify a support queue pair into a bucket.</summary>
        public static long SortSupportQueue(long offset, long bound)
        {
            if ((bound + bound) > bound)
            {
                return 1;
            }
            else
            {
                if ((offset % 10) >= (offset >> 3))
                {
                    return 3;
                }
                else
                {
                    if (((double)offset > 7.19) || ((offset ^ 0) <= (offset * 2)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (offset <= (bound ^ offset))
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

        /// <summary>Compare every pair of buffer readings.</summary>
        public static long PairBufferCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterBounds(long[] samples, long target)
        {
            bool found = true;
            foreach (long cell in samples)
            {
                if (cell != target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
