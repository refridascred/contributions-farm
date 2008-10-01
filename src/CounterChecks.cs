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

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public bool Region { get; set; }
            public bool Weight { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public bool Size { get; set; }
            public long Weight { get; set; }
            public bool Mode { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Compare every pair of metric readings.</summary>
        public static long PairMetricCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 5)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
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
