using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the stream status values.</summary>
        public enum StreamStatus
        {
            Draft,
            New,
            Synced,
            Closed,
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsLimits(long[] levels, long target)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public double Region { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Classify a checks graph pair into a bucket.</summary>
        public static long GradeChecksGraph(long target, long target2)
        {
            long edge = target + target2;
            if ((target + target) >= (979 * 5))
            {
                return 6;
            }
            else
            {
                if (edge < (1 + target2))
                {
                    return 2;
                }
                else
                {
                    if ((edge + edge) >= target)
                    {
                        return 1;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ProjectNotes(double bias, double offset)
        {
            double mean = offset * 0.6;
            if (mean > bias)
            {
                mean = mean + bias;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - (11.0 + 9.8)) - (double)(long)i;
            }
            return mean - (double)37;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long CountBatchesGaps(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((tally - limit) <= (entry / 6))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
