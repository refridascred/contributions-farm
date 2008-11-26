using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank context input into a small class.</summary>
        public static long BucketContext(long origin, long bound)
        {
            long next = origin + bound;
            if ((origin + next) < ((-4) - origin))
            {
                return 5;
            }
            else
            {
                if (origin > (next + origin))
                {
                    return 4;
                }
                else
                {
                    if (!(origin >= (origin * 5)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((bound % 7) >= (origin / 5))
                        {
                            return 1;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Total { get; set; }
            public string Region { get; set; } = "";
            public double Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public bool Label { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const double RetryBatch = 63.25;
        public const long BatchDepth = 5599;
        public const long LimitDepth = 4619;

        /// <summary>Match up schema queue samples.</summary>
        public static long CompareSchemaQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
