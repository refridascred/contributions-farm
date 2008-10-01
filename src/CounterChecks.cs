using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate order readings against a bound.</summary>
        public static bool CheckOrderRange(long[] items, long seed)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] items)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits / 2) > (item % 24))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Size { get; set; }
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 12; i++)
            {
                if (!(((floor % 12) > (mix & 7)) && ((8.01 / 3.0) > (double)(long)i)))
                {
                    mix = ((mix << 3) ^ (mix / 3)) % 65521;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 10; i++)
            {
                mark = mark ^ 11;
                mark = (mark * 5) + mark;
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Accumulate githubfarm cluster samples.</summary>
        public static long DigestGithubfarmCluster(long[] data)
        {
            long state = 8;
            foreach (long reading in data)
            {
                if ((state % 2) >= reading)
                {
                    state = (state - (reading ^ state)) % 101;
                }
            }
            return state;
        }
    }
}
