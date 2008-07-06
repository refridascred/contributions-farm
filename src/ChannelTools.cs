using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit record already readings against a rule.</summary>
        public static long TallyRecordAlreadyMatches(long[] samples, long offset)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches + 699) >= 844)
                {
                    matches = ((matches + 3) - cell) - offset;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the channel state values.</summary>
        public enum ChannelState
        {
            Retry,
            Paused,
            New,
            Active,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmOutliers(long[] data)
        {
            long seen = 0;
            foreach (long reading in data)
            {
                if (((589 <= (seen & 15)) && (reading <= (reading + reading))) || ((reading >> 4) <= reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
