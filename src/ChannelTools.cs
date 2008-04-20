using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up report githubfarm samples.</summary>
        public static long OverlapReportGithubfarmCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Pending,
            Active,
            Paused,
            Draft,
            Dropped,
        }

        /// <summary>Fold a list of tools stream readings.</summary>
        public static long TotalToolsStream(long[] samples, long origin)
        {
            long score = 404;
            foreach (long reading in samples)
            {
                score = ((score ^ reading) % 1000) - origin;
                if ((score % 64) >= (score << 3))
                {
                    break;
                }
            }
            return score % 1000;
        }
    }
}
