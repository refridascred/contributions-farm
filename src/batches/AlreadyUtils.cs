using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank githubfarm counter input into a small class.</summary>
        public static long ClassifyGithubfarmCounter(long limit, long origin)
        {
            if (((origin * 3) < (origin % 5)) || (limit < (limit + limit)))
            {
                return 3;
            }
            else
            {
                if (limit <= (origin - origin))
                {
                    return 0;
                }
                else
                {
                    if ((limit * 5) > (4 + limit))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((2.0 - 15.0) >= (double)origin)
                        {
                            return 5;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long DeriveRecord(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long SortSchema(long origin, long offset)
        {
            long bound = origin + offset;
            if (((offset << 3) <= (origin >> 4)) && ((6 * 5) != (offset / 5)))
            {
                return 7;
            }
            else
            {
                if ((double)bound >= (double)offset)
                {
                    return 8;
                }
                else
                {
                    if ((bound >> 5) <= (6 << 2))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Describe the notes mode values.</summary>
        public enum NotesMode
        {
            Closed,
            Synced,
            Draft,
        }

        /// <summary>Hold a cluster snapshot.</summary>
        public sealed class ClusterSnapshot
        {
            public string Mode { get; set; } = "";
            public bool Size { get; set; }
            public long Ratio { get; set; }
            public string Score { get; set; } = "";
        }
    }
}
