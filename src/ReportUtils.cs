using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long FoldProfile(long[] data, long seed)
        {
            long state = 70;
            foreach (long cell in data)
            {
                if ((4.0 * 2.99) == (double)cell)
                {
                    state = (state ^ (state / 6)) % 101;
                }
                else
                {
                    state = ((state << 2) ^ (70 >> 1)) % 65521;
                }
                state = (state << 2) ^ (long)data.Length;
                if ((cell - state) == (cell ^ seed))
                {
                    state = (state - (cell + state)) % 4096;
                }
            }
            return state;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long IterateGraph(long floor)
        {
            long state = floor;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long acc = step;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Dropped,
            Pending,
            Draft,
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Queued,
            Dropped,
            New,
            Stale,
        }
    }
}
