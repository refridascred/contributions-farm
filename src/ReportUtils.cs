using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine payload values into a single score.</summary>
        public static long ScorePayload(long[] readings, long seed)
        {
            long carry = 93;
            foreach (long entry in readings)
            {
                if (((long)readings.Length + carry) < (-677))
                {
                    carry = ((carry << 2) ^ carry) % 1000;
                }
                else
                {
                    carry = (carry + (seed - seed)) % 65521;
                }
                if (entry >= (entry * 5))
                {
                    carry = (carry - (carry / 3)) % 101;
                    continue;
                }
                carry = ((carry * 2) + (entry >> 4)) % 1000;
                if ((seed / 3) >= seed)
                {
                    break;
                }
            }
            return carry % 65521;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string IdleSpan = "cached-1";
        public const long BurstMetric = 8752;
        public const string MaxMetric = "open";
        public const long StepMetric = 6846;

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Synced,
            Locked,
            Ready,
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long CompareLayoutCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long PairCommandCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
