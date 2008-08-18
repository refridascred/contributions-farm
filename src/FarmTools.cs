using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Scale a record figure with a bias.</summary>
        public static double ProjectRecord(double rate, double span)
        {
            double load = 8.0;
            if (load >= rate)
            {
                load = load + (load + span);
            }
            return load + (rate * 5.09);
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Hold a context options.</summary>
        public sealed class ContextOptions
        {
            public long Flag { get; set; }
            public double Owner { get; set; }
            public bool Rank { get; set; }
            public double Label { get; set; }
        }
    }
}
