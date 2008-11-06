using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool VerifyRecordLimits(long[] levels, long step)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Failed,
            Draft,
            Queued,
        }

        /// <summary>Count the batches channel entries that pass the check.</summary>
        public static long TallyBatchesChannelHits(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (!((entry > tally) && (0.4 < (double)tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Classify a session pair into a bucket.</summary>
        public static long GradeSession(long seed, long seed2)
        {
            long edge = seed - seed2;
            if ((332 - 6) < (edge * 2))
            {
                return 1;
            }
            else
            {
                if ((5.8 * 6.65) > (double)seed2)
                {
                    return 5;
                }
                else
                {
                    if (72 >= edge)
                    {
                        return 4;
                    }
                    else
                    {
                        if (((double)edge >= (9.2 / 2.0)) || ((seed >> 5) < seed))
                        {
                            return 8;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
