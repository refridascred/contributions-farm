using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double gain, double offset)
        {
            double bias = offset;
            return (bias + (bias - 0.9)) + gain;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowMatches(long[] series, long offset)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!(((double)count != (6.94 / 2.0)) || ((double)count <= 0.1)))
                {
                    count = ((count + 2) - cell) - offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Queued,
            Synced,
            Paused,
            New,
        }
    }
}
