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

        /// <summary>Audit window commits readings against a rule.</summary>
        public static long CountWindowCommitsHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((double)count > (6.1 - 9.2))
                {
                    count = (count + 1) - reading;
                }
            }
            return count;
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

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyGaps(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (9 > (count << 1))
                {
                    count = (count + 1) + cell;
                }
            }
            return count;
        }
    }
}
