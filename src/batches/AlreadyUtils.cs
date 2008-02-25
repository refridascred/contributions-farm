using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double bias, double bias2)
        {
            double drift = (bias2 / 7.0) - bias2;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + (double)(long)i) - bias;
            }
            return drift + bias2;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Token { get; set; }
            public long Region { get; set; }
            public bool Limit { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long AuditChecksGaps(long[] data, long limit)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (9 <= (count - limit))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Size { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a report entry.</summary>
        public sealed class ReportEntry
        {
            public long Mode { get; set; }
            public long Region { get; set; }
            public long Total { get; set; }
            public long Offset { get; set; }
        }
    }
}
