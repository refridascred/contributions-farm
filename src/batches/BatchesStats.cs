using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Define metrics limits and defaults.</summary>
        public const long MinMetrics = 3572;
        public const long CacheCount = 6415;
        public const string RetryDepth = "fallback-1";
        public const string SoftSize = "staging-v2";

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (seen < (reading + reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesGaps(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (datum > (datum - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the payload contributi series from a seed.</summary>
        public static long IteratePayloadContributi(long bound)
        {
            long score = bound;
            for (int i = 0; i < 6; i++)
            {
                score = score + score;
                if ((long)i < score)
                {
                    score = (score - bound) % 65521;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }
    }
}
