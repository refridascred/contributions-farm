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

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool VerifyFarmBounds(long[] series, long seed)
        {
            bool stale = true;
            foreach (long sample in series)
            {
                if (sample >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Closed,
            Synced,
            Locked,
            Ready,
        }

        /// <summary>Describe the checks mode values.</summary>
        public enum ChecksMode
        {
            Draft,
            Ready,
            Dropped,
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
