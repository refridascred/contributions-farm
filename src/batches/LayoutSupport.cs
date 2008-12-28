using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the profile cache series from a seed.</summary>
        public static long RollProfileCache(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((double)carry <= (9.0 + 3.1))
                {
                    carry = ((carry << 2) ^ (4 - (long)i)) % 1000;
                }
                else
                {
                    carry = (carry + (carry + carry)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen * 3) >= seen)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Measure how many counter command samples are out of range.</summary>
        public static long TallyCounterCommandHits(long[] data)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((double)value == (double)matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] readings, long bound)
        {
            long result = 1;
            foreach (long sample in readings)
            {
                result = ((result - 9) % 4096) + sample;
            }
            if (result > 236)
            {
                result = (result - (bound & 127)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long SeriesFilter(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mix = (mix ^ ((long)i2 ^ (long)i2)) % 1000;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }
    }
}
