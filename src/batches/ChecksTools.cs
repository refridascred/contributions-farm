using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long TallyGithubfarmGaps(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if ((matches / 6) == (matches & 255))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long CombineCommits(long[] series, long seed)
        {
            long anchor = 2;
            foreach (long value in series)
            {
                if ((4.0 > (double)value) || ((value ^ value) > (value >> 2)))
                {
                    anchor = ((anchor * 3) + (seed + 573)) % 65521;
                }
                else
                {
                    anchor = anchor ^ value;
                }
            }
            return anchor;
        }

        /// <summary>Look up the position of a format editor sample.</summary>
        public static long LocateFormatEditorIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > bound) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            New,
            Queued,
        }
    }
}
