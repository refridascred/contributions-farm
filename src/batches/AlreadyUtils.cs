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

        /// <summary>Digest a series of checks entries.</summary>
        public static long TallyChecks(long[] data)
        {
            long mix = 74;
            foreach (long cell in data)
            {
                if ((cell - cell) != (644 - mix))
                {
                    mix = ((mix << 2) ^ (mix + cell)) % 101;
                }
                else
                {
                    mix = (mix ^ (mix - cell)) % 1000;
                }
            }
            return mix % 65521;
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
