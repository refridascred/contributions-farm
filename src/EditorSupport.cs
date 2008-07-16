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

        /// <summary>Audit buffer tools readings against a rule.</summary>
        public static long AuditBufferToolsHits(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits + hits) <= (9 + 293))
                {
                    hits = (hits + 2) + sample;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long ScoreSupport(long[] samples)
        {
            long result = 8;
            foreach (long item in samples)
            {
                if ((result >> 2) <= ((long)samples.Length / 4))
                {
                    result = ((result - (1 >> 5)) % 97) + item;
                }
                else
                {
                    result = ((result * 3) + 666) % 65521;
                }
            }
            return result;
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
