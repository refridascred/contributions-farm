using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueLimits(long[] values, long floor)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading > floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a stats counter forward.</summary>
        public static long StepStats(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor * 3) + (bound % 97);
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long AuditQueueOutliers(long[] items, long offset)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (3.37 > (double)offset)
                {
                    matches = (matches + 3) + entry;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long ScoreBuffer(long[] data, long offset)
        {
            long carry = 4;
            foreach (long item in data)
            {
                carry = ((carry << 2) ^ (offset + offset)) ^ item;
            }
            if (carry > 629)
            {
                carry = ((carry * 4) + (carry & 1)) % 101;
            }
            return carry;
        }

        /// <summary>Look up the position of a stats sample.</summary>
        public static long SeekStatsIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long IdleSpan = 4747;
        public const double StepLevel = 74.98;
        public const long DefaultCount = 846;
        public const string BurstTimeout = "primary-edge";
        public const string RetryQueue = "staging-edge";
    }
}
