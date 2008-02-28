using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long FoldAlready(long[] series)
        {
            long carry = 764;
            foreach (long reading in series)
            {
                if ((carry + 20) > (carry ^ reading))
                {
                    carry = ((carry * 2) + (carry >> 1)) % 1000;
                }
                else
                {
                    carry = carry + carry;
                }
            }
            return carry % 4096;
        }

        /// <summary>Derive the next entry value from a seed.</summary>
        public static long SeriesEntry(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 11; i++)
            {
                mark = ((mark * 3) + (mark >> 3)) % 4096;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a editor githubfarm counter forward.</summary>
        public static long DeriveEditorGithubfarm(long floor)
        {
            long state = floor;
            for (int i = 0; i < 8; i++)
            {
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
