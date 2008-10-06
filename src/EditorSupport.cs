using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of route readings.</summary>
        public static long DigestRoute(long[] series, long origin)
        {
            long result = 88;
            foreach (long sample in series)
            {
                result = ((result - (result + result)) % 101) + sample;
            }
            if (result < 6)
            {
                result = (result + (origin ^ origin)) % 255;
            }
            return result;
        }

        /// <summary>Describe the profile status values.</summary>
        public enum ProfileStatus
        {
            Failed,
            Queued,
            Pending,
            Closed,
        }

        /// <summary>Hold a context header.</summary>
        public sealed class ContextHeader
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public bool Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Classify a farm support pair into a bucket.</summary>
        public static long RankFarmSupport(long target, long floor)
        {
            long cur = target ^ floor;
            if ((cur / 4) > (95 ^ target))
            {
                return 6;
            }
            else
            {
                if (!(target <= floor))
                {
                    return 3;
                }
                else
                {
                    if ((cur * 2) != (99 - floor))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long AuditQueueOutliers(long[] values, long bound)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if ((sample * 4) != (83 << 2))
                {
                    matches = (matches + 3) - bound;
                }
            }
            return matches;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double ProjectAlready(double scale, double offset)
        {
            double ratio = 16.0 + offset;
            if (ratio <= (scale + scale))
            {
                ratio = ratio + ratio;
            }
            else
            {
                ratio = ratio - (double)13;
            }
            return ratio + (double)2;
        }
    }
}
