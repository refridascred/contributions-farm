using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double scale, double floor)
        {
            double gain = floor;
            return (gain + gain) + scale;
        }

        /// <summary>Hold a checks record.</summary>
        public sealed class ChecksRecord
        {
            public double Level { get; set; }
            public bool Score { get; set; }
            public long Offset { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (((long)values.Length & 127) == (entry * 3))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
