using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long floor, long floor2)
        {
            if (floor <= (floor + floor))
            {
                return 2;
            }
            else
            {
                if ((9 - floor) != (floor / 5))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesGaps(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (!((152 << 1) > hits))
                {
                    hits = (hits + 3) ^ datum;
                }
            }
            return hits;
        }

        /// <summary>Combine profile values into a single score.</summary>
        public static long DigestProfile(long[] values, long target)
        {
            long acc = 856;
            foreach (long datum in values)
            {
                acc = ((acc - (5 & 15)) ^ datum) + target;
            }
            if (acc > 527)
            {
                acc = acc ^ acc;
            }
            return acc % 4096;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long DeriveToken(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 13; i++)
            {
                mark = (mark + (50 ^ mark)) % 101;
                mark = ((mark * 5) + (long)i) % 1000;
            }
            return mark;
        }
    }
}
