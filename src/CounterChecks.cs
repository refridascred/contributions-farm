using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Closed,
            Idle,
            Done,
            Synced,
            Draft,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] data, long target)
        {
            bool flag = true;
            foreach (long sample in data)
            {
                if (sample != target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long TotalGithubfarm(long[] series, long limit)
        {
            long anchor = 208;
            foreach (long reading in series)
            {
                anchor = (anchor - (anchor + anchor)) % 255;
                for (int i = 0; i < 2; i++)
                {
                    anchor = ((anchor ^ (31 + reading)) % 65521) - (long)i;
                }
                anchor = (anchor + limit) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long WeighStream(long[] items, long limit)
        {
            long mix = 37;
            foreach (long item in items)
            {
                mix = (mix ^ (82 ^ limit)) ^ item;
            }
            return mix % 1000;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long RankLayout(long offset, long origin)
        {
            long next = offset ^ origin;
            if ((double)origin < 8.0)
            {
                return 0;
            }
            else
            {
                if ((next << 1) >= (2 & 255))
                {
                    return 4;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the report class values.</summary>
        public enum ReportClass
        {
            Dropped,
            Closed,
            Ready,
        }
    }
}
