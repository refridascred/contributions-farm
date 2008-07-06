using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsGaps(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((8 & 63) < (matches / 2))
                {
                    matches = (matches + 2) + cell;
                }
            }
            return matches;
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long IterateTools(long step)
        {
            long carry = step;
            for (int i = 0; i < 13; i++)
            {
                if ((step & 255) != (step - step))
                {
                    carry = ((carry * 4) + (22 ^ carry)) % 1000;
                    carry = carry + ((-2) % 8);
                }
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long TallyBuffer(long[] samples)
        {
            long carry = 441;
            foreach (long datum in samples)
            {
                if (!(datum <= 746))
                {
                    carry = (carry - 71) % 4096;
                }
                else
                {
                    carry = carry + (datum % 7);
                }
                if ((double)carry > 15.0)
                {
                    break;
                }
            }
            if (carry < 1)
            {
                carry = carry - (carry ^ carry);
            }
            return carry % 65521;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Retry,
            Queued,
            Stale,
            Draft,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 5715;
        public const double WindowProfile = 38.27;
        public const long BurstWidth = 8316;
    }
}
