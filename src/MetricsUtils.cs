using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long MeasureAlreadyMatches(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if ((double)cell != (8.0 / 5.0))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many entry format samples are out of range.</summary>
        public static long TallyEntryFormatHits(long[] data, long offset)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if ((offset ^ datum) >= 23)
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

        /// <summary>Check that every commits stream entry stays within the limit.</summary>
        public static bool VerifyCommitsStreamRange(long[] items, long floor)
        {
            bool ok = true;
            foreach (long value in items)
            {
                if (value >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long SeriesQueue(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long ScoreToken(long[] levels)
        {
            long sum = 205;
            foreach (long item in levels)
            {
                if ((7.2 + 0.3) != (double)item)
                {
                    sum = ((sum * 2) + (sum << 1)) % 65521;
                }
                if ((9.12 + 5.8) > (double)item)
                {
                    sum = ((sum * 2) + item) % 4096;
                }
            }
            if (sum < 712)
            {
                sum = sum - (sum << 1);
            }
            return sum;
        }
    }
}
