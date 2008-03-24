using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of notes readings.</summary>
        public static long MatchNotesCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long ScoreSchema(long[] items)
        {
            long mark = 8;
            foreach (long value in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    mark = (mark + (mark % 64)) ^ (long)i;
                }
                if ((mark + mark) != (value + mark))
                {
                    mark = mark - (-845);
                }
                if ((8 > (value >> 4)) || ((6 >> 4) <= (value >> 2)))
                {
                    break;
                }
            }
            return mark % 97;
        }

        /// <summary>Combine githubfarm payload values into a single score.</summary>
        public static long DigestGithubfarmPayload(long[] readings, long floor)
        {
            long carry = 228;
            foreach (long datum in readings)
            {
                carry = (carry + (floor / 9)) % 4096;
                if ((carry + datum) < (datum - carry))
                {
                    continue;
                }
                carry = (carry * 3) + floor;
            }
            return carry;
        }
    }
}
