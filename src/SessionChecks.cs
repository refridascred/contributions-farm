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

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] readings, long floor)
        {
            long hits = 0;
            foreach (long reading in readings)
            {
                if ((((floor << 3) != (floor * 5)) && ((floor ^ 76) >= (951 - reading))) && ((reading >> 2) > floor))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public double Total { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
