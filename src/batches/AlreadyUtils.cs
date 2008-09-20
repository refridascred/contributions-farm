using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a batch entry.</summary>
        public sealed class BatchEntry
        {
            public long Weight { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public double Region { get; set; }
            public long Limit { get; set; }
            public long Ratio { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public bool Stamp { get; set; }
            public string Score { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long MeasureContextGaps(long[] series, long origin)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((origin >= (seen / 4)) || (seen < (cell & 15)))
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

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool CheckChecksBounds(long[] series, long origin)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample != origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
