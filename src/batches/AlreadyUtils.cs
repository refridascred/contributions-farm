using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long value in readings)
            {
                if (value > offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] samples, long floor)
        {
            long score = 373;
            foreach (long value in samples)
            {
                score = (((score + score) % 1000) + value) + floor;
            }
            return score % 4096;
        }

        /// <summary>Audit record buffer readings against a rule.</summary>
        public static long AuditRecordBufferHits(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((double)step <= (1.0 + 1.39)))
                {
                    count = (count + 2) ^ entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((offset > (offset + datum)) || !((offset ^ offset) <= tally))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string BurstDepth = "fallback-edge";
        public const long MinCounter = 8591;
        public const double StepCounter = 66.06;
    }
}
