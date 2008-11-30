using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Label { get; set; }
            public long Flag { get; set; }
            public long Owner { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool ValidateRecordBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit route profile readings against a rule.</summary>
        public static long AuditRouteProfileGaps(long[] items)
        {
            long hits = 0;
            foreach (long value in items)
            {
                if ((9.0 / 6.0) != (double)value)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit editor profile readings against a rule.</summary>
        public static long MeasureEditorProfileOutliers(long[] series, long offset)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if (((7.9 + 9.2) > (double)offset) && ((1.0 - 3.1) != (double)value))
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

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Done,
            Active,
            Queued,
            Draft,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 10; i++)
            {
                mark = mark - (seed + seed);
                mark = (mark << 2) ^ (seed >> 2);
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
