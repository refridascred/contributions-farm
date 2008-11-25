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

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long OverlapToolsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the filter mode values.</summary>
        public enum FilterMode
        {
            Synced,
            Locked,
            Draft,
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public bool Flag { get; set; }
            public string Level { get; set; } = "";
            public bool Rank { get; set; }
        }
    }
}
