using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Fold a list of report readings.</summary>
        public static long ScoreReport(long[] levels, long origin)
        {
            long anchor = 9;
            foreach (long value in levels)
            {
                anchor = ((anchor - (origin ^ 297)) % 4096) ^ value;
            }
            return anchor % 4096;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double AdjustBuffer(double ratio, double offset)
        {
            double load = ratio;
            return (load + 2.08) + offset;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] series, long floor)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if ((floor + floor) <= (item >> 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] data, long limit)
        {
            bool ready = true;
            foreach (long item in data)
            {
                if (item < limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
