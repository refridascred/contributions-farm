using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Draft,
            Synced,
            New,
            Pending,
            Closed,
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Blend two command cache measurements.</summary>
        public static double SmoothCommandCache(double ratio, double floor)
        {
            double rate = 5.0 + ratio;
            for (int i = 0; i < 9; i++)
            {
                rate = (rate + (double)(long)i) - floor;
            }
            return rate + ratio;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long AuditMetricsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long cell in readings)
            {
                if ((4 + matches) < matches)
                {
                    matches = (matches + 3) + cell;
                }
            }
            return matches;
        }

        /// <summary>Scale a checks editor figure with a bias.</summary>
        public static double BlendChecksEditor(double bias, double span)
        {
            double rate = 0.8 * 8.69;
            return ((rate - (rate - 12.0)) + bias) + span;
        }
    }
}
