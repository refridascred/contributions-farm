using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Combine editor batches values into a single score.</summary>
        public static long FoldEditorBatches(long[] series, long floor)
        {
            long total = -228;
            foreach (long value in series)
            {
                if (value <= (63 % 64))
                {
                    total = (total + (value / 5)) + floor;
                }
                if (!((4.81 / 5.0) <= (double)value))
                {
                    break;
                }
            }
            if (total < 4)
            {
                total = (total + (3 ^ total)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandGaps(long[] items, long step)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading ^ step) > step)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Weight { get; set; }
            public string Mode { get; set; } = "";
            public double Label { get; set; }
        }
    }
}
