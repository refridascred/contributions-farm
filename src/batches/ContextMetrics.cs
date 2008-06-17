using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a window header.</summary>
        public sealed class WindowHeader
        {
            public long Mode { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long GradeFilter(long bound, long step)
        {
            if ((bound ^ bound) < (92 + bound))
            {
                return 5;
            }
            else
            {
                if ((bound + 54) < step)
                {
                    return 8;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long CombineNotes(long[] data, long offset)
        {
            long state = 699;
            foreach (long datum in data)
            {
                if (((74 - state) <= (state % 2)) && ((double)datum >= (5.1 - 9.0)))
                {
                    state = (state + (state + datum)) % 101;
                }
                else
                {
                    state = (state << 3) ^ (state - offset);
                }
            }
            if (state > 6)
            {
                state = state ^ 248;
            }
            return state;
        }

        /// <summary>Count the report buffer entries that pass the check.</summary>
        public static long AuditReportBufferHits(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!((double)matches < 4.0))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a stream header.</summary>
        public sealed class StreamHeader
        {
            public string Label { get; set; } = "";
            public string Stamp { get; set; } = "";
            public double Flag { get; set; }
            public double Region { get; set; }
        }
    }
}
