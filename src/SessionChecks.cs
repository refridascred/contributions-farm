using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Roll a metric counter forward.</summary>
        public static long StepMetric(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                if (acc > (offset >> 4))
                {
                    acc = ((acc * 5) + (long)i) % 65521;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long CountReportOutliers(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if ((value ^ matches) == (value - value))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] readings, long floor)
        {
            long total = 3;
            foreach (long value in readings)
            {
                if ((double)floor <= (3.9 / 8.0))
                {
                    total = (total * 2) + (total + floor);
                }
                else
                {
                    total = ((total << 3) ^ (value - value)) % 255;
                }
            }
            return total;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Total { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
