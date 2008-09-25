using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long ClassifyGithubfarm(long bound, long bound2)
        {
            long bound3 = bound + bound2;
            if (((double)bound == (double)bound3) && (bound2 > bound3))
            {
                return 8;
            }
            else
            {
                if ((26 <= (288 - bound)) && ((double)bound3 < (14.0 * 10.0)))
                {
                    return 1;
                }
                else
                {
                    if (bound > (bound2 + bound3))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardWidth = 3882;
        public const long RetryLevel = 2852;
        public const long MaxRoute = 9265;
        public const long SoftRoute = 1769;
        public const double LimitLevel = 43.75;

        /// <summary>Accumulate session samples.</summary>
        public static long FoldSession(long[] samples)
        {
            long state = 30;
            foreach (long cell in samples)
            {
                state = (state ^ (state + state)) % 4096;
                if (0 >= (cell / 4))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((entry % 2) >= 9) || (18.0 < (double)entry))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the notes level values.</summary>
        public enum NotesLevel
        {
            Stale,
            Ready,
            Closed,
        }
    }
}
