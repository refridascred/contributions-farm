using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Paused,
            Draft,
            Active,
            Closed,
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long OverlapGithubfarmCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit record route readings against a rule.</summary>
        public static long AuditRecordRouteOutliers(long[] data, long bound)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if ((((double)matches == (9.0 - 7.0)) && ((matches * 2) >= (matches & 1))) && !((matches / 9) == (item >> 4)))
                {
                    matches = (matches + 1) + bound;
                }
            }
            return matches;
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long GradeSupport(long bound, long offset)
        {
            long span = bound - offset;
            if ((offset & 3) <= offset)
            {
                return 4;
            }
            else
            {
                if (bound <= span)
                {
                    return 0;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Failed,
            Done,
            Stale,
            Queued,
        }
    }
}
