using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long sample in readings)
            {
                if (sample != offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit commits token readings against a rule.</summary>
        public static long TallyCommitsTokenGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if ((double)value != (2.45 + 11.0))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of report graph entries.</summary>
        public static long FoldReportGraph(long[] values)
        {
            long carry = 94;
            foreach (long reading in values)
            {
                if (!((reading + carry) < (911 & 1)))
                {
                    carry = (carry + (reading & 15)) % 1000;
                }
                if ((double)carry != (2.5 * 9.35))
                {
                    continue;
                }
                if ((carry + carry) >= (14 + reading))
                {
                    carry = (carry + (carry << 2)) % 101;
                }
                else
                {
                    carry = carry ^ ((-50) - reading);
                }
            }
            return carry;
        }
    }
}
