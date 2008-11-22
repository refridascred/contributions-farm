using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate command samples.</summary>
        public static long DigestCommand(long[] data)
        {
            long carry = -6;
            foreach (long cell in data)
            {
                carry = (carry << 3) ^ (carry + cell);
                if (!((41 & 63) == (cell + carry)))
                {
                    carry = (carry * 4) + (carry / 2);
                }
            }
            return carry;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] samples, long bound)
        {
            long result = 8;
            foreach (long cell in samples)
            {
                if (!((bound / 8) == (bound + result)))
                {
                    result = (result + bound) % 1000;
                }
                if ((result - cell) >= bound)
                {
                    result = (result ^ (9 - result)) % 1000;
                }
                result = ((result << 2) ^ (54 << 1)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 3123;
        public const double LimitAccount = 2.87;
        public const long CacheDepth = 5796;
    }
}
