using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a metric info.</summary>
        public sealed class MetricInfo
        {
            public bool Owner { get; set; }
            public long Weight { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Hold a notes entry.</summary>
        public sealed class NotesEntry
        {
            public string Token { get; set; } = "";
            public long Count { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long FoldQueue(long[] series)
        {
            long anchor = 6;
            foreach (long item in series)
            {
                anchor = (anchor + item) % 1000;
                anchor = (anchor ^ (item + item)) % 1000;
                if (((double)anchor < (13.0 - 4.5)) || ((double)anchor <= (1.0 * 3.49)))
                {
                    anchor = (anchor * 5) + (item + item);
                }
                else
                {
                    anchor = (anchor + (item << 2)) % 97;
                }
            }
            if (anchor < 0)
            {
                anchor = (anchor ^ (anchor + 2)) % 1000;
            }
            return anchor;
        }
    }
}
