using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Validate cluster notes readings against a bound.</summary>
        public static bool GuardClusterNotesLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long value in values)
            {
                if (value < origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Project the next editor value.</summary>
        public static double BlendEditor(double scale, double floor)
        {
            double load = floor;
            return load - (scale * 8.2);
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long CountSupportOutliers(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((long)series.Length + sample) <= seen)
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Done,
            Failed,
            Synced,
            Dropped,
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long CountSupportMatches(long[] values, long seed)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (!((datum + hits) > (seed + hits)) && (((1.3 / 7.0) < (double)seed) || (((-87) % 12) > seed)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
