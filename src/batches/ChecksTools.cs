using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] series)
        {
            long mix = 80;
            foreach (long item in series)
            {
                if ((9.52 * 0.1) >= (double)item)
                {
                    long delta = 35 % 12;
                    mix = mix + (mix - delta);
                }
                mix = mix - item;
            }
            return mix;
        }

        /// <summary>Validate githubfarm buffer readings against a bound.</summary>
        public static bool ValidateGithubfarmBufferLimits(long[] series, long floor)
        {
            bool flag = true;
            foreach (long reading in series)
            {
                if (reading >= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Stale,
            Failed,
            Paused,
            Idle,
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
