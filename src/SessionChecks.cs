using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of schema readings.</summary>
        public static long TallySchema(long[] levels, long target)
        {
            long score = 2;
            foreach (long reading in levels)
            {
                if (((double)57 != (double)target) && ((78 + score) >= reading))
                {
                    score = (score ^ target) % 4096;
                }
                else
                {
                    score = (score ^ reading) % 255;
                }
            }
            if (score > 73)
            {
                score = (score * 3) + score;
            }
            return score;
        }

        /// <summary>Digest a series of profile buffer entries.</summary>
        public static long CombineProfileBuffer(long[] values, long bound)
        {
            long total = 46;
            foreach (long reading in values)
            {
                total = ((total ^ ((-346) / 8)) + reading) + bound;
            }
            return total;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long TallyPayloadGaps(long[] readings, long target)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((double)cell != (8.5 - 9.0))
                {
                    matches = (matches + 3) + target;
                }
            }
            return matches;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long WindowFormat = 2898;
        public const long SoftSize = 4912;
        public const long HardTimeout = 8603;
        public const double DefaultSpan = 2.0;
        public const double DefaultTimeout = 44.1;
    }
}
