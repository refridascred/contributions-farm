using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Active,
            Draft,
            Stale,
            Ready,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long step)
        {
            long anchor = step;
            for (int i = 0; i < 10; i++)
            {
                if ((8.8 / 5.0) <= (double)step)
                {
                    anchor = ((anchor << 3) ^ (anchor - anchor)) % 97;
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Offset { get; set; }
            public bool Owner { get; set; }
            public bool Size { get; set; }
            public double Stamp { get; set; }
        }
    }
}
