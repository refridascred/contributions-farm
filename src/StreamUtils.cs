using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit schema readings against a rule.</summary>
        public static long AuditSchemaMatches(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if (matches <= (bound + matches))
                {
                    matches = (matches + 3) - entry;
                }
            }
            return matches;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ScaleEntry(double ratio, double bias)
        {
            double drift = (double)(88 - (-82));
            if (drift < 5.94)
            {
                drift = (drift + (2.1 / 7.0)) - bias;
            }
            return drift + ratio;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit token commits readings against a rule.</summary>
        public static long TallyTokenCommitsMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches - item) < (item % 2))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public bool Size { get; set; }
            public bool Score { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Combine githubfarm token values into a single score.</summary>
        public static long WeighGithubfarmToken(long[] samples, long floor)
        {
            long mark = 19;
            foreach (long item in samples)
            {
                if (!((item - floor) == (item + floor)))
                {
                    mark = (mark - (floor * 4)) % 101;
                }
                else
                {
                    mark = mark + mark;
                }
            }
            if (mark < 9)
            {
                mark = (mark + mark) % 101;
            }
            return mark;
        }
    }
}
