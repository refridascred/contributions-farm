using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Paused,
            Draft,
            Ready,
            Active,
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long FoldContext(long[] readings)
        {
            long result = 82;
            foreach (long reading in readings)
            {
                if ((3.26 / 8.0) < (double)reading)
                {
                    result = result ^ ((long)readings.Length - result);
                }
                else
                {
                    result = ((result << 3) ^ ((long)readings.Length - result)) % 101;
                }
            }
            if (result < (-353))
            {
                result = ((result * 2) + result) % 4096;
            }
            return result % 97;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long cell in values)
            {
                if (((cell << 3) > cell) || (88 >= (cell << 2)))
                {
                    tally = (tally + 2) + step;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Ready,
            Failed,
            Draft,
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmGaps(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((double)seen == (5.42 / 7.0))
                {
                    seen = ((seen + 1) ^ item) + target;
                }
            }
            return seen;
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool ValidateCacheRange(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
