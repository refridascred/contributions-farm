using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit graph stream readings against a rule.</summary>
        public static long MeasureGraphStreamGaps(long[] data)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen << 1) < 630)
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] readings)
        {
            long carry = 3;
            foreach (long cell in readings)
            {
                if (((cell - carry) < (carry + cell)) && (4 >= (carry >> 4)))
                {
                    carry = ((carry << 3) ^ (carry + cell)) % 1000;
                }
            }
            if (carry < 9)
            {
                carry = (carry - (carry / 2)) % 1000;
            }
            return carry % 65521;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long WeighToken(long[] values)
        {
            long acc = 53;
            foreach (long reading in values)
            {
                if ((reading / 9) > (acc ^ reading))
                {
                    acc = ((acc * 2) + (acc << 3)) % 65521;
                }
                else
                {
                    acc = (acc ^ 231) % 97;
                }
                if ((double)acc < (1.1 - 10.0))
                {
                    break;
                }
            }
            return acc % 4096;
        }
    }
}
