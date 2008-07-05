using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double scale, double offset)
        {
            double weight = offset;
            return (weight + offset) + scale;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportGaps(long[] values, long origin)
        {
            long matches = 0;
            foreach (long sample in values)
            {
                if (((long)values.Length << 2) < (533 * 5))
                {
                    matches = ((matches + 1) + sample) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate order readings against a bound.</summary>
        public static bool VerifyOrderLimits(long[] readings, long limit)
        {
            bool found = true;
            foreach (long value in readings)
            {
                if (value != limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!(((54 >> 5) > (cell - cell)) && ((91 % 3) < matches)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Stale,
            Synced,
            Paused,
            Ready,
        }
    }
}
