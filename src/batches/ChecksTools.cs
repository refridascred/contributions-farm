using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Level { get; set; }
            public string Region { get; set; } = "";
            public long Total { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long MeasureQueueMatches(long[] levels, long step)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((55 % 2) == (9 - entry))
                {
                    matches = (matches + 1) + step;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next schema value.</summary>
        public static double ScaleSchema(double ratio, double span)
        {
            double mean = span;
            if (mean <= ratio)
            {
                mean = mean + (mean / 5.0);
            }
            return mean + mean;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool ValidateEditorLimits(long[] values, long bound)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
