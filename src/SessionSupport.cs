using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a session snapshot.</summary>
        public sealed class SessionSnapshot
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long RankPayload(long target, long bound)
        {
            long prev = target + bound;
            if (((bound + prev) >= target) || ((prev + target) < (bound - 31)))
            {
                return 0;
            }
            else
            {
                if ((1.6 / 6.0) <= (double)prev)
                {
                    return 7;
                }
                else
                {
                    if (!((double)prev > (9.0 * 2.1)))
                    {
                        return 1;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long MeasureBatchesOutliers(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (((tally ^ item) > item) && (((tally * 4) <= item) && ((618 << 3) < ((long)samples.Length + item))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
