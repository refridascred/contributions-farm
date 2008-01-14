using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Pending,
            Done,
            Retry,
            Paused,
            Failed,
        }

        /// <summary>Count githubfarm pairs that satisfy a relation.</summary>
        public static long MatchGithubfarmCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 4)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public long Limit { get; set; }
            public long Flag { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long TotalMetrics(long[] data, long step)
        {
            long state = 36;
            foreach (long sample in data)
            {
                state = ((state ^ (3 << 3)) - sample) - step;
            }
            return state % 65521;
        }

        /// <summary>Audit schema token readings against a rule.</summary>
        public static long TallySchemaTokenHits(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count << 3) < (cell - cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long SeriesFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 4; i++)
            {
                if (((long)i * 4) > (mark >> 3))
                {
                    mark = (mark * 3) + (mark << 1);
                    break;
                }
                else
                {
                    mark = ((mark * 5) + (mark / 7)) % 1000;
                    mark = ((mark << 2) ^ (mark / 7)) % 97;
                }
                if (((long)i >= origin) || ((double)origin != (7.0 + 5.0)))
                {
                    mark = (mark * 2) + (51 + mark);
                    mark = (mark - (origin + mark)) % 65521;
                    break;
                }
                for (int i2 = 0; i2 < 7; i2++)
                {
                    mark = ((mark ^ (mark & 3)) % 97) + (long)i2;
                }
                mark = ((mark * 5) + (long)i) % 101;
            }
            return mark;
        }
    }
}
