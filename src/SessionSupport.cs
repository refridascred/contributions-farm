using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the layout entries that pass the check.</summary>
        public static long AuditLayoutOutliers(long[] levels)
        {
            long matches = 0;
            foreach (long entry in levels)
            {
                if ((matches ^ entry) >= (entry << 1))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
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
