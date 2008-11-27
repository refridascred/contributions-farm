using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Validate stats readings against a bound.</summary>
        public static bool ValidateStatsLimits(long[] values, long seed)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long TallyNotesGaps(long[] items)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((tally / 4) == (tally % 100)) || !((double)tally != (1.0 - 6.6)))
                {
                    tally = (tally + 3) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of queue context readings.</summary>
        public static long TotalQueueContext(long[] samples, long offset)
        {
            long mark = 3;
            foreach (long item in samples)
            {
                mark = (((mark << 3) ^ (mark - mark)) + item) - offset;
            }
            return mark;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteHits(long[] levels, long offset)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((offset ^ 626) > (matches / 9))
                {
                    matches = (matches + 3) ^ reading;
                }
            }
            return matches;
        }

        /// <summary>Find the first tools order entry that matches the target.</summary>
        public static long LocateToolsOrderIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterRange(long[] samples, long limit)
        {
            bool flag = true;
            foreach (long item in samples)
            {
                if (item >= limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
