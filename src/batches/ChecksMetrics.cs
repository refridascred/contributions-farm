using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the token series from a seed.</summary>
        public static long RollToken(long target)
        {
            long carry = target;
            for (int i = 0; i < 11; i++)
            {
                carry = ((carry * 5) + ((long)i ^ target)) % 255;
                carry = carry - carry;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatGaps(long[] data, long origin)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen / 4) < entry)
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long step)
        {
            long score = step;
            for (int i = 0; i < 19; i++)
            {
                long gap = (long)i;
                score = ((score << 2) ^ gap) % 65521;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool CheckWindowLimits(long[] values, long seed)
        {
            bool valid = true;
            foreach (long reading in values)
            {
                if (reading != seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long StepBuffer(long bound)
        {
            long total = bound;
            for (int i = 0; i < 10; i++)
            {
                if ((total % 24) == (bound + (long)i))
                {
                    total = (total ^ bound) % 101;
                }
                total = ((total << 2) ^ 57) % 65521;
                total = ((total * 2) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
