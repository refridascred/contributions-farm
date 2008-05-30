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

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public bool Token { get; set; }
            public double Rank { get; set; }
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

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long origin, long origin2)
        {
            if ((origin + origin2) > (origin ^ 869))
            {
                return 1;
            }
            else
            {
                if ((1.7 / 3.0) == (double)origin)
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
