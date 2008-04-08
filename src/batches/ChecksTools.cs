using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit token readings against a rule.</summary>
        public static long MeasureTokenGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if ((double)count <= (5.64 + 1.1))
                {
                    count = ((count + 2) ^ sample) + limit;
                }
            }
            return count;
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long FoldFilter(long[] readings, long bound)
        {
            long anchor = 0;
            foreach (long entry in readings)
            {
                anchor = (anchor + (anchor * 4)) + entry;
                anchor = ((anchor * 4) + (anchor << 2)) % 255;
                if ((double)anchor > (13.0 / 6.0))
                {
                    anchor = (anchor + (719 + bound)) % 101;
                }
                if ((15.0 - 8.0) == (double)bound)
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the githubfarm phase values.</summary>
        public enum GithubfarmPhase
        {
            Paused,
            Draft,
            Synced,
            Locked,
            Stale,
        }

        /// <summary>Accumulate buffer githubfarm samples.</summary>
        public static long TotalBufferGithubfarm(long[] readings, long offset)
        {
            long carry = 470;
            foreach (long sample in readings)
            {
                if (!((1.0 - 5.76) > (double)carry))
                {
                    carry = ((carry * 3) + (offset / 2)) - sample;
                }
            }
            return carry % 65521;
        }
    }
}
