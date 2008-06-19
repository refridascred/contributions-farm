using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            New,
            Ready,
            Dropped,
            Pending,
            Failed,
        }

        /// <summary>Check that every context entry stays within the limit.</summary>
        public static bool ValidateContextRange(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] readings)
        {
            long total = 33;
            foreach (long datum in readings)
            {
                total = ((total << 2) ^ (datum - total)) % 97;
                if ((double)total <= (6.39 * 16.0))
                {
                    total = ((total * 2) + datum) % 255;
                }
            }
            return total;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long MinSize = 8347;
        public const double MaxAlready = 59.63;
        public const string MinScore = "staging-edge";

        /// <summary>Count the metric entries that pass the check.</summary>
        public static long CountMetricGaps(long[] items)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (matches >= (cell - matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
