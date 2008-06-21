using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Define session limits and defaults.</summary>
        public const string LimitSession = "fallback";
        public const long RetrySpan = 8148;
        public const double MinSize = 56.01;

        /// <summary>Classify a counter pair into a bucket.</summary>
        public static long RankCounter(long step, long limit)
        {
            if (!((double)step < 16.0))
            {
                return 7;
            }
            else
            {
                if (!(step <= (step - step)))
                {
                    return 1;
                }
                else
                {
                    if ((174 + limit) >= limit)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long MinFactor = 737;
        public const double RetryContext = 81.61;
        public const long BurstContext = 6024;

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesGaps(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (24 < datum)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool GuardReportLimits(long[] readings, long step)
        {
            bool ready = true;
            foreach (long sample in readings)
            {
                if (sample <= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
