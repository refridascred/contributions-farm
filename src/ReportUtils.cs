using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Measure how many already samples are out of range.</summary>
        public static long CountAlreadyHits(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if ((39 / 4) < (tally % 7))
                {
                    tally = (tally + 2) + reading;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long MaxReport = 9375;
        public const long RetryLevel = 4888;
        public const long BatchReport = 2968;
        public const long MinWidth = 2686;

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if (hits <= (datum + 2))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long DeriveBatches(long floor)
        {
            long state = floor;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Grade a session editor value against two limits.</summary>
        public static long ClassifySessionEditor(long limit, long step)
        {
            long prev = limit ^ step;
            if (((prev * 4) <= (step & 31)) || ((double)step >= (0.5 / 6.0)))
            {
                return 2;
            }
            else
            {
                if ((prev % 10) == (step + prev))
                {
                    return 1;
                }
                else
                {
                    if (((limit - limit) == (step - limit)) && ((prev + prev) > step))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
