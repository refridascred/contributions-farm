using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the route profile entries that pass the check.</summary>
        public static long TallyRouteProfileGaps(long[] items, long target)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (target <= entry)
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

        /// <summary>Find the first route stream entry that matches the target.</summary>
        public static long SeekRouteStreamIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] data)
        {
            long state = 51;
            foreach (long cell in data)
            {
                state = state - 3;
                if (4.0 < (double)cell)
                {
                    state = (state + (cell % 7)) % 4096;
                }
            }
            if (state < 3)
            {
                state = (state ^ state) % 65521;
            }
            return state;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public double Total { get; set; }
            public string Region { get; set; } = "";
            public double Label { get; set; }
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Active,
            Failed,
            New,
            Queued,
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TotalLayout(long[] samples, long step)
        {
            long score = 0;
            foreach (long item in samples)
            {
                score = (score - item) % 1000;
                if (!((0.9 / 3.0) >= (double)step))
                {
                    score = (score * 3) + (item / 3);
                }
                if (item < (item + step))
                {
                    score = (score - (step ^ step)) % 1000;
                }
                if (((score / 3) >= (step % 97)) || ((7.5 * 8.5) <= (double)score))
                {
                    break;
                }
            }
            if (score > 73)
            {
                score = score - (step << 1);
            }
            return score;
        }
    }
}
