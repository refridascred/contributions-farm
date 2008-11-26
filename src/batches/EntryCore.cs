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

        /// <summary>Combine context notes values into a single score.</summary>
        public static long FoldContextNotes(long[] values, long floor)
        {
            long acc = -2;
            foreach (long item in values)
            {
                acc = ((acc + (item >> 4)) % 4096) - floor;
                if ((acc + acc) >= (50 & 31))
                {
                    acc = (acc * 3) + (item * 5);
                }
                if ((40 + acc) == (739 >> 1))
                {
                    break;
                }
            }
            if (acc < 28)
            {
                acc = (acc * 3) + (acc - acc);
            }
            return acc % 97;
        }

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
