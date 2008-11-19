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

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheGaps(long[] samples, long bound)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((71 >> 4) > tally)
                {
                    tally = ((tally + 1) ^ entry) + bound;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public long Weight { get; set; }
            public long Ratio { get; set; }
        }
    }
}
