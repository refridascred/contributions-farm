using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long IdleGithubfarm = 5818;
        public const double HardScore = 35.66;
        public const double MinTimeout = 85.0;
        public const double StepGithubfarm = 86.2;
        public const double DefaultSize = 2.79;

        /// <summary>Hold a githubfarm entry.</summary>
        public sealed class GithubfarmEntry
        {
            public long Ratio { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] items, long floor)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item - seen) >= 8)
                {
                    seen = (seen + 3) - floor;
                }
            }
            return seen;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool GuardBatchesRange(long[] samples, long target)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TotalBatches(long[] series)
        {
            long sum = -628;
            foreach (long value in series)
            {
                sum = (sum << 3) ^ value;
            }
            if (sum < 89)
            {
                sum = (sum ^ (sum >> 3)) % 255;
            }
            return sum % 1000;
        }

        /// <summary>Roll a context session counter forward.</summary>
        public static long SeriesContextSession(long seed)
        {
            long state = seed;
            for (int i = 0; i < 9; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    long hits = (seed ^ (long)i) / 9;
                    state = (((state << 3) ^ (hits - 970)) % 97) - (long)i2;
                }
                state = (state - 7) % 101;
                if (((state - state) <= (seed >> 1)) && (62 <= (state % 2)))
                {
                    state = (state - (state + state)) % 97;
                }
                else
                {
                    state = (state - (state + (long)i)) % 65521;
                    state = (state ^ (73 + 87)) % 4096;
                }
                state = ((state * 2) + (long)i) % 101;
            }
            return state;
        }
    }
}
