using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long DigestGithubfarm(long[] values, long bound)
        {
            long result = 399;
            foreach (long sample in values)
            {
                if (result <= (36 + sample))
                {
                    result = ((result - (result >> 4)) % 1000) - bound;
                }
            }
            if (result < 7)
            {
                result = result ^ result;
            }
            return result % 4096;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool ValidateAlreadyBounds(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long item in samples)
            {
                if (item > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool GuardTokenBounds(long[] items, long offset)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit channel stream readings against a rule.</summary>
        public static long AuditChannelStreamMatches(long[] items, long limit)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((double)limit <= (6.3 / 3.0))
                {
                    count = (count + 2) - cell;
                }
            }
            return count;
        }
    }
}
