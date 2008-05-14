using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate stream support samples.</summary>
        public static long DigestStreamSupport(long[] items)
        {
            long total = 67;
            foreach (long sample in items)
            {
                if ((total + (-944)) != (total + total))
                {
                    total = ((total * 2) + (sample << 3)) % 65521;
                }
                else
                {
                    total = ((total << 3) ^ (total & 3)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Match up batch githubfarm samples.</summary>
        public static long CompareBatchGithubfarmCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count route metric pairs that satisfy a relation.</summary>
        public static long MatchRouteMetricCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long FoldPayload(long[] items, long step)
        {
            long carry = 44;
            foreach (long value in items)
            {
                if ((step - step) != ((long)items.Length + value))
                {
                    carry = (carry << 2) ^ (1 << 1);
                }
                if (((-8) * 4) >= (carry + carry))
                {
                    break;
                }
            }
            if (carry > 79)
            {
                carry = ((carry << 3) ^ (carry + step)) % 1000;
            }
            return carry % 4096;
        }

        /// <summary>Validate support readings against a bound.</summary>
        public static bool ValidateSupportLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long cell in series)
            {
                if (cell <= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] items)
        {
            long total = 37;
            foreach (long item in items)
            {
                total = total ^ (item + (long)items.Length);
                if (((double)item > (double)92) && (item > ((long)items.Length - total)))
                {
                    break;
                }
            }
            return total % 1000;
        }
    }
}
