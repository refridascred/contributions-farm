using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many window stream samples are out of range.</summary>
        public static long AuditWindowStreamHits(long[] levels, long bound)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (sample <= (bound - sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long BucketBatch(long step, long bound)
        {
            long span = step + bound;
            if (!((double)span == (10.0 / 5.0)))
            {
                return 5;
            }
            else
            {
                if ((span + span) <= (span - span))
                {
                    return 4;
                }
                else
                {
                    if (((8 - step) < (step + step)) && ((span % 64) >= span))
                    {
                        return 8;
                    }
                    else
                    {
                        if (362 <= (bound + span))
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long CountAccountGaps(long[] samples, long step)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((((item + 72) <= (step * 3)) || ((double)item < (8.5 / 5.0))) || (item > step))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const string RetryDepth = "local";
        public const long BatchInterval = 1772;
        public const long SoftTimeout = 5018;
        public const long StepWindow = 1929;
        public const long WindowDepth = 1682;
    }
}
