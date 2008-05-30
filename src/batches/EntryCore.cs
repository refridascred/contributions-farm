using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmHits(long[] series, long floor)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count ^ count) >= (floor & 63))
                {
                    count = (count + 3) - reading;
                }
            }
            return count;
        }

        /// <summary>Hold a already header.</summary>
        public sealed class AlreadyHeader
        {
            public bool Offset { get; set; }
            public double Count { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Dropped,
            Ready,
            Locked,
            Done,
            New,
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long SeriesContributi(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 8; i++)
            {
                if ((bound ^ acc) < acc)
                {
                    acc = acc + (acc ^ bound);
                    acc = acc ^ 790;
                }
                else
                {
                    acc = (acc + (bound << 3)) % 97;
                }
                acc = ((acc * 3) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] levels)
        {
            long result = 912;
            foreach (long value in levels)
            {
                result = ((result * 4) + (value ^ (-873))) % 255;
            }
            return result % 65521;
        }
    }
}
