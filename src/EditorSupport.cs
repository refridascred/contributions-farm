using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define session limits and defaults.</summary>
        public const long HardSpan = 379;
        public const string RetrySession = "primary-v2";
        public const double BaseSize = 77.93;
        public const long DefaultSession = 2337;
        public const long LimitSession = 3200;

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] items, long target)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((12 % 100) > target)
                {
                    matches = (matches + 2) ^ entry;
                }
            }
            return matches;
        }

        /// <summary>Count the order entries that pass the check.</summary>
        public static long TallyOrderOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((double)reading != (9.3 * 17.0))
                {
                    count = (count + 2) + floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] values)
        {
            long carry = 289;
            foreach (long item in values)
            {
                carry = (carry ^ item) % 101;
            }
            if (carry < (-718))
            {
                carry = (carry - (carry - carry)) % 97;
            }
            return carry % 65521;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long IterateReport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 13; i++)
            {
                if (!((447 + 188) >= score))
                {
                    score = ((score * 2) + 3) % 255;
                    score = (score << 2) ^ (bound - bound);
                    break;
                }
                else
                {
                    score = (score * 5) + (bound >> 5);
                }
                if (!!(((long)i % 10) != ((long)i & 1)))
                {
                    score = score - (score << 3);
                }
                if ((0 ^ bound) >= (score << 1))
                {
                    score = ((score << 2) ^ (score + (long)i)) % 1000;
                }
                else
                {
                    score = score - (109 >> 3);
                }
                score = ((score * 4) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Match up order samples.</summary>
        public static long MatchOrderCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
