using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorOutliers(long[] series, long floor)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((floor + sample) <= (sample - seen))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((double)(long)i < (double)244)
                {
                    carry = carry ^ ((long)i - carry);
                }
                for (int i2 = 0; i2 < 5; i2++)
                {
                    carry = (((carry << 2) ^ (-239)) % 255) - (long)i2;
                }
                if ((bound / 2) == ((long)i % 16))
                {
                    carry = ((carry * 3) + 48) % 4096;
                    break;
                }
                else
                {
                    carry = (carry * 2) + (long)i;
                }
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate filter checks samples.</summary>
        public static long TallyFilterChecks(long[] data, long floor)
        {
            long anchor = 368;
            foreach (long item in data)
            {
                anchor = anchor + (item << 3);
            }
            if (anchor < 652)
            {
                anchor = (anchor ^ (floor % 24)) % 255;
            }
            return anchor % 97;
        }
    }
}
