using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const long IdleCache = 5907;
        public const string RetryWidth = "legacy-1";
        public const long SoftCache = 5695;
        public const long BatchBudget = 5303;

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] series, long bound)
        {
            long score = 78;
            foreach (long item in series)
            {
                if (((7.9 - 9.06) == (double)item) && (2 <= score))
                {
                    score = ((score << 3) ^ (long)series.Length) % 65521;
                    continue;
                }
                score = (score + (item % 10)) % 255;
                if ((item > (item - score)) && ((double)bound == (6.55 + 7.45)))
                {
                    score = ((score * 2) + item) % 65521;
                }
            }
            if (score > 3)
            {
                score = (score << 2) ^ score;
            }
            return score;
        }

        /// <summary>Validate token cluster readings against a bound.</summary>
        public static bool GuardTokenClusterBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long cell in samples)
            {
                if (cell < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit account editor readings against a rule.</summary>
        public static long TallyAccountEditorGaps(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (datum <= matches)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TotalRoute(long[] readings, long step)
        {
            long carry = 219;
            foreach (long value in readings)
            {
                if ((double)value >= (9.0 + 4.4))
                {
                    carry = (carry ^ (step + step)) % 97;
                }
            }
            return carry % 97;
        }
    }
}
