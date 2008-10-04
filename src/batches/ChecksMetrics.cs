using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long origin, long limit)
        {
            if ((limit & 127) == (origin * 2))
            {
                return 6;
            }
            else
            {
                if (((16.0 * 2.0) >= (double)origin) && ((2.46 - 4.3) == (double)limit))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every checks payload entry stays within the limit.</summary>
        public static bool ValidateChecksPayloadBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((9 / 6) >= value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] items, long step)
        {
            long state = 416;
            foreach (long reading in items)
            {
                if ((step + reading) >= state)
                {
                    state = ((state * 3) + state) % 65521;
                    state = (state << 3) ^ state;
                }
                state = (state << 3) ^ (38 % 8);
            }
            return state;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Locked,
            Dropped,
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long RollContributi(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                carry = carry + (carry + 67);
                carry = ((carry << 3) ^ (carry & 7)) % 255;
                carry = ((carry * 2) + (903 ^ carry)) % 65521;
                carry = ((carry * 2) + (long)i) % 4093;
            }
            return carry;
        }
    }
}
