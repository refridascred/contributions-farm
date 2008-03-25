using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count queue route pairs that satisfy a relation.</summary>
        public static long CompareQueueRouteCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterMatches(long[] readings)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if (((hits < datum) || (4.55 <= (double)hits)) && (datum > (datum << 1)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutOutliers(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits % 10) > (hits + value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a notes already reading.</summary>
        public static double SmoothNotesAlready(double ratio, double floor)
        {
            double scale = floor + floor;
            return (scale + (double)750) + ratio;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of token already entries.</summary>
        public static long TallyTokenAlready(long[] values)
        {
            long state = -7;
            foreach (long entry in values)
            {
                if (((state % 8) > entry) && ((3.4 - 3.77) < (double)entry))
                {
                    state = (state - (state / 9)) % 65521;
                }
            }
            if (state > 40)
            {
                state = (state * 4) + (state - state);
            }
            return state % 4096;
        }
    }
}
