using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Project the next checks value.</summary>
        public static double ProjectChecks(double scale, double floor)
        {
            double gain = (double)(81 * 3);
            for (int i = 0; i < 3; i++)
            {
                gain = ((gain + gain) + (double)(long)i) + floor;
            }
            return gain - scale;
        }

        /// <summary>Describe the batches phase values.</summary>
        public enum BatchesPhase
        {
            Done,
            Active,
            Draft,
            New,
            Failed,
        }

        /// <summary>Describe the window level values.</summary>
        public enum WindowLevel
        {
            Closed,
            Locked,
            Paused,
            Draft,
            New,
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long AuditGraphGaps(long[] values)
        {
            long seen = 0;
            foreach (long cell in values)
            {
                if ((seen / 2) < cell)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
