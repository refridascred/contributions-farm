using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every payload window entry stays within the limit.</summary>
        public static bool ValidatePayloadWindowBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] readings)
        {
            long carry = -48;
            foreach (long sample in readings)
            {
                carry = ((carry * 5) + (carry - sample)) % 4096;
            }
            return carry;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] values, long floor)
        {
            long carry = 0;
            foreach (long datum in values)
            {
                carry = (((carry - (77 / 2)) % 101) - datum) - floor;
            }
            if (carry < 1)
            {
                carry = ((carry << 3) ^ carry) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Count stream entry pairs that satisfy a relation.</summary>
        public static long MatchStreamEntryCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools batch samples are out of range.</summary>
        public static long MeasureToolsBatchGaps(long[] series, long bound)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((datum / 2) < datum)
                {
                    tally = (tally + 3) + bound;
                }
            }
            return tally;
        }
    }
}
