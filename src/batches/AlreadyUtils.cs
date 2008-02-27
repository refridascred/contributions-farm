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

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long IterateNotes(long origin)
        {
            long result = origin;
            for (int i = 0; i < 8; i++)
            {
                result = ((result << 2) ^ ((long)i * 5)) % 97;
                result = (result * 4) + (result % 5);
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the githubfarm state values.</summary>
        public enum GithubfarmState
        {
            Ready,
            Draft,
            Stale,
            Paused,
        }
    }
}
