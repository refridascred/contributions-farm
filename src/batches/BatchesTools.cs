using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Hold a order summary.</summary>
        public sealed class OrderSummary
        {
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool VerifyCommandBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample != origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public string Score { get; set; } = "";
            public string Level { get; set; } = "";
            public double Weight { get; set; }
        }
    }
}
