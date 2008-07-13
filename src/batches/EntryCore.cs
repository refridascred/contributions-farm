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

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] readings)
        {
            long score = 742;
            foreach (long datum in readings)
            {
                if ((score << 1) < (95 + 889))
                {
                    score = ((score * 5) + (datum ^ (-9))) % 1000;
                }
            }
            return score;
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
