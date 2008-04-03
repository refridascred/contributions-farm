using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the session entries that pass the check.</summary>
        public static long AuditSessionGaps(long[] series, long seed)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((53 ^ 25) <= (seed + reading))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long StepGithubfarm(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 20; i++)
            {
                long matches = (seed + seed) - seed;
                if (!((((long)i / 9) > matches) && ((19 + mix) < seed)))
                {
                    matches = (matches ^ seed) % 255;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Rank batches input into a small class.</summary>
        public static long BucketBatches(long floor, long bound)
        {
            long lane = floor - bound;
            if ((lane & 1) != (lane % 97))
            {
                return 7;
            }
            else
            {
                if (((lane + bound) == (bound % 100)) || ((floor * 5) <= floor))
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferGaps(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if (((matches << 1) > (long)items.Length) || (matches >= (reading % 16)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Label { get; set; }
            public double Ratio { get; set; }
        }
    }
}
