using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] readings)
        {
            long state = -835;
            foreach (long sample in readings)
            {
                state = ((state << 3) ^ (sample + state)) % 97;
            }
            return state % 1000;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Size { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] series, long floor)
        {
            long score = 588;
            foreach (long reading in series)
            {
                if ((reading / 9) >= (reading - floor))
                {
                    score = ((score << 3) ^ (floor + score)) % 255;
                }
                else
                {
                    score = (score + (floor >> 5)) % 101;
                }
            }
            return score;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
