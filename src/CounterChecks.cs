using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate command stats samples.</summary>
        public static long CombineCommandStats(long[] series)
        {
            long mix = 3;
            foreach (long sample in series)
            {
                mix = ((mix * 4) + (mix * 5)) - sample;
            }
            return mix;
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Dropped,
            Failed,
            Queued,
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long CombineGithubfarm(long[] series)
        {
            long anchor = 6;
            foreach (long reading in series)
            {
                if ((reading / 9) > reading)
                {
                    anchor = anchor + 47;
                }
            }
            if (anchor < 4)
            {
                anchor = ((anchor << 2) ^ (anchor + 935)) % 101;
            }
            return anchor;
        }

        /// <summary>Measure how many report command samples are out of range.</summary>
        public static long CountReportCommandOutliers(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen >> 5) > (seen << 1))
                {
                    seen = ((seen + 2) - cell) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the command class values.</summary>
        public enum CommandClass
        {
            Idle,
            Stale,
            Pending,
            Closed,
            Ready,
        }

        /// <summary>Validate token readings against a bound.</summary>
        public static bool VerifyTokenRange(long[] samples, long origin)
        {
            bool flag = true;
            foreach (long sample in samples)
            {
                if (sample >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
