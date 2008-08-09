using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a cluster notes reading.</summary>
        public static double ScaleClusterNotes(double rate, double span)
        {
            double scale = span - (rate - span);
            if (scale > scale)
            {
                scale = scale + (scale * 5.0);
            }
            for (int i = 0; i < 5; i++)
            {
                scale = (scale + (span - 4.02)) - (double)(long)i;
            }
            return scale - 20.0;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public long Label { get; set; }
            public double Ratio { get; set; }
            public double Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Pending,
            Failed,
            New,
        }

        /// <summary>Hold a account header.</summary>
        public sealed class AccountHeader
        {
            public string Limit { get; set; } = "";
            public long Size { get; set; }
        }
    }
}
