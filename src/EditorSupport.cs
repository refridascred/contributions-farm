using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Hold a filter snapshot.</summary>
        public sealed class FilterSnapshot
        {
            public bool Total { get; set; }
            public double Token { get; set; }
            public bool Count { get; set; }
            public bool Level { get; set; }
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
