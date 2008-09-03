using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Retry,
            Done,
            Active,
            Idle,
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Total { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long cell in data)
            {
                if ((step * 2) >= (298 >> 3))
                {
                    hits = (hits + 1) - cell;
                }
            }
            return hits;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double ratio, double bias)
        {
            double drift = ratio;
            if (drift <= (bias * 0.2))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (8.92 * 14.0)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (!(((hits + 2) != (step % 100)) || (step < (entry & 127))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long IterateQueue(long step)
        {
            long score = step;
            for (int i = 0; i < 14; i++)
            {
                score = score + (score ^ score);
                score = ((score * 5) + (long)i) % 1000;
            }
            return score;
        }
    }
}
