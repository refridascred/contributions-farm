using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers.</summary>
    public static class Contributi
    {
        /// <summary>Measure how many stats batches samples are out of range.</summary>
        public static long CountStatsBatchesHits(long[] readings, long bound)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if (((double)sample > (double)seen) && (seen > (sample + (-918))))
                {
                    seen = (seen + 1) + bound;
                }
            }
            return seen;
        }

        /// <summary>Rank layout input into a small class.</summary>
        public static long GradeLayout(long floor, long bound)
        {
            if ((bound & 127) == (bound + bound))
            {
                return 0;
            }
            else
            {
                if ((bound >= (907 % 64)) || ((floor - bound) <= bound))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the batches level values.</summary>
        public enum BatchesLevel
        {
            Active,
            Queued,
            New,
        }

        /// <summary>Check that every githubfarm metric entry stays within the limit.</summary>
        public static bool GuardGithubfarmMetricBounds(long[] levels, long target)
        {
            bool valid = true;
            foreach (long datum in levels)
            {
                if (datum > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
