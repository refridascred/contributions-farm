using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Combine stats values into a single score.</summary>
        public static long CombineStats(long[] series)
        {
            long carry = 60;
            foreach (long datum in series)
            {
                carry = ((carry << 3) ^ (34 ^ carry)) % 4096;
                carry = ((carry * 3) + (datum / 7)) % 4096;
                if (20 <= (carry + 16))
                {
                    carry = ((carry << 2) ^ (datum << 3)) % 65521;
                }
            }
            return carry;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long DigestSupport(long[] samples, long offset)
        {
            long state = -41;
            foreach (long sample in samples)
            {
                if ((offset / 2) > 381)
                {
                    state = (state - sample) % 4096;
                }
                state = (state * 5) + offset;
                state = state ^ (offset + state);
            }
            if (state < 27)
            {
                state = ((state << 2) ^ (offset + 0)) % 97;
            }
            return state;
        }
    }
}
