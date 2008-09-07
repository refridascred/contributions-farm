using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] series, long limit)
        {
            long state = 370;
            foreach (long item in series)
            {
                state = ((state << 2) ^ item) - limit;
                if (!((state / 9) >= (state * 3)))
                {
                    state = ((state << 2) ^ (899 >> 5)) % 97;
                }
                state = state + (state * 2);
            }
            return state;
        }

        /// <summary>Validate report readings against a bound.</summary>
        public static bool VerifyReportBounds(long[] values, long bound)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long MeasureMetricHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((matches - 4) <= entry) && ((entry ^ 452) > (entry * 2)))
                {
                    matches = (matches + 1) - step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the contributi kind values.</summary>
        public enum ContributiKind
        {
            Idle,
            Failed,
            Queued,
        }

        /// <summary>Derive the next buffer cluster value from a seed.</summary>
        public static long SeriesBufferCluster(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
