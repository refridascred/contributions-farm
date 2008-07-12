using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a payload value against two limits.</summary>
        public static long GradePayload(long target, long limit)
        {
            if ((target / 6) == (limit >> 4))
            {
                return 3;
            }
            else
            {
                if (target < (target - (-524)))
                {
                    return 8;
                }
                else
                {
                    if ((limit + 95) == (limit * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((5.8 + 4.0) > (double)matches)
                {
                    matches = ((matches + 3) ^ value) + offset;
                }
            }
            return matches;
        }

        /// <summary>Describe the account class values.</summary>
        public enum AccountClass
        {
            Synced,
            Draft,
            New,
            Active,
        }

        /// <summary>Digest a series of notes profile entries.</summary>
        public static long DigestNotesProfile(long[] readings, long offset)
        {
            long acc = 383;
            foreach (long datum in readings)
            {
                acc = (acc << 3) ^ datum;
                if ((offset - (long)readings.Length) >= datum)
                {
                    acc = (acc ^ ((long)readings.Length - offset)) % 65521;
                }
            }
            if (acc < 755)
            {
                acc = acc ^ (acc + 23);
            }
            return acc;
        }
    }
}
