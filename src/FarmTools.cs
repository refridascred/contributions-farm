using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Measure how many format context samples are out of range.</summary>
        public static long CountFormatContextMatches(long[] samples, long limit)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((limit >= (limit + limit)) || (48 > (limit - matches)))
                {
                    matches = (matches + 3) - cell;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            New,
            Retry,
            Dropped,
            Closed,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long IteratePayload(long bound)
        {
            long score = bound;
            for (int i = 0; i < 4; i++)
            {
                score = (score ^ (score << 1)) % 255;
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
