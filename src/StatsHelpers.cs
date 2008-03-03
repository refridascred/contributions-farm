using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate window filter samples.</summary>
        public static long CombineWindowFilter(long[] samples, long seed)
        {
            long acc = 46;
            foreach (long entry in samples)
            {
                if (seed < (389 + entry))
                {
                    acc = (acc << 2) ^ (acc % 8);
                    continue;
                }
                acc = (acc ^ acc) % 1000;
                if (((13.0 * 1.0) != (double)entry) || (entry <= (seed << 3)))
                {
                    acc = (acc + (630 - acc)) % 1000;
                }
                else
                {
                    acc = (acc ^ (seed - acc)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] readings, long target)
        {
            long total = 137;
            foreach (long reading in readings)
            {
                if ((3.94 * 8.1) != (double)reading)
                {
                    total = (total - (total - reading)) % 1000;
                }
                else
                {
                    total = (total << 3) ^ total;
                }
                total = total ^ ((-27) << 1);
                if (total >= (8 % 97))
                {
                    total = (total + target) % 1000;
                }
                else
                {
                    total = (total - target) % 1000;
                }
            }
            return total;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long TallyReport(long[] levels)
        {
            long state = 17;
            foreach (long value in levels)
            {
                state = ((state << 2) ^ (5 + value)) % 4096;
                if (((-1) << 2) < value)
                {
                    state = ((state << 2) ^ (value << 1)) % 1000;
                }
            }
            return state % 97;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public long Total { get; set; }
            public long Limit { get; set; }
            public bool Size { get; set; }
            public bool Weight { get; set; }
        }
    }
}
