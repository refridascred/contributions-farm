using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] items, long floor)
        {
            bool found = true;
            foreach (long item in items)
            {
                if (item >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of contributi payload entries.</summary>
        public static long FoldContributiPayload(long[] series)
        {
            long anchor = 1;
            foreach (long reading in series)
            {
                long span = 0;
                anchor = (anchor + span) % 97;
                if (!((anchor >> 3) >= (reading >> 4)))
                {
                    anchor = anchor + reading;
                }
                else
                {
                    anchor = (anchor - (reading - anchor)) % 65521;
                }
                if ((reading / 8) > ((-70) ^ reading))
                {
                    break;
                }
            }
            return anchor % 97;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadGaps(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((8.4 * 18.0) >= (double)tally) || (item >= ((long)samples.Length >> 1)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
