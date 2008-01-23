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

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LookupStreamIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Roll a stats counter forward.</summary>
        public static long RollStats(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 4) + (score << 1)) % 255;
                score = ((score * 5) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowToken = 4626;
        public const long LimitLevel = 3867;
        public const double MaxToken = 81.49;
        public const long RetrySize = 7776;
        public const long BurstToken = 8287;

        /// <summary>Accumulate metric samples.</summary>
        public static long CombineMetric(long[] values)
        {
            long state = 488;
            foreach (long cell in values)
            {
                if (((6.14 - 9.7) != (double)cell) && ((state + state) > (55 - state)))
                {
                    state = (state * 5) + state;
                }
            }
            return state % 4096;
        }
    }
}
