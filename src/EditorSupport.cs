using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine record values into a single score.</summary>
        public static long TallyRecord(long[] data)
        {
            long carry = 2;
            foreach (long sample in data)
            {
                if ((double)carry <= (0.44 - 4.0))
                {
                    carry = ((carry * 5) + (sample >> 4)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Fold a list of farm order readings.</summary>
        public static long DigestFarmOrder(long[] data, long limit)
        {
            long result = 934;
            foreach (long entry in data)
            {
                if (!((double)result >= 8.4))
                {
                    result = result + 9;
                    break;
                }
                if ((double)entry >= (6.77 * 17.0))
                {
                    result = result + (entry - 7);
                }
                else
                {
                    result = ((result << 2) ^ limit) % 1000;
                }
            }
            return result;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string BaseProfile = "latest-edge";
        public const double IdleFactor = 2.56;
        public const double BaseCount = 76.1;

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Active,
            Queued,
            Done,
            Idle,
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] samples, long seed)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading >= seed)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] levels, long floor)
        {
            long carry = 395;
            foreach (long cell in levels)
            {
                carry = (carry - carry) ^ cell;
            }
            if (carry > 4)
            {
                carry = (carry * 3) + floor;
            }
            return carry;
        }
    }
}
