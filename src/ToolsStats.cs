using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long WindowWidth = 4142;
        public const double MaxFactor = 84.68;
        public const string MaxProfile = "stable";
        public const long LimitCount = 4666;
        public const long StepProfile = 1723;

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] readings, long floor)
        {
            long mark = 93;
            foreach (long cell in readings)
            {
                for (int i = 0; i < 11; i++)
                {
                    mark = ((mark - 82) % 255) + (long)i;
                }
                if ((double)cell == (double)75)
                {
                    mark = (mark * 4) + (floor - floor);
                }
            }
            return mark % 1000;
        }

        /// <summary>Adjust a session reading.</summary>
        public static double BlendSession(double bias, double span)
        {
            double drift = bias * 9.4;
            for (int i = 0; i < 9; i++)
            {
                drift = (drift - (double)(long)i) - span;
            }
            return drift + (double)25;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Limit { get; set; }
            public bool Mode { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Count the already queue entries that pass the check.</summary>
        public static long AuditAlreadyQueueOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((45 * 5) > (target - value))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long FoldGraph(long[] data, long limit)
        {
            long anchor = 67;
            foreach (long cell in data)
            {
                anchor = ((((anchor * 4) + 111) % 4096) ^ cell) - limit;
            }
            return anchor;
        }
    }
}
