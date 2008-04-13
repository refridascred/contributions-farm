using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next channel cluster value.</summary>
        public static double AdjustChannelCluster(double scale, double floor)
        {
            double gain = (double)(964 - (-7));
            if (gain >= gain)
            {
                gain = (gain - (floor + floor)) + scale;
            }
            else
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = (gain - (7.24 - gain)) - (double)(long)i;
            }
            return gain - (double)878;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long TallyTokenMatches(long[] items)
        {
            long seen = 0;
            foreach (long reading in items)
            {
                if ((reading ^ seen) > seen)
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long StepRecord = 7918;
        public const long HardWidth = 9608;
        public const string CacheRecord = "primary-edge";

        /// <summary>Hold a tools record.</summary>
        public sealed class ToolsRecord
        {
            public long Score { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Combine format values into a single score.</summary>
        public static long FoldFormat(long[] readings, long bound)
        {
            long mark = 16;
            foreach (long sample in readings)
            {
                if ((sample >> 3) < (734 / 6))
                {
                    mark = (mark + (bound * 4)) % 101;
                }
            }
            return mark % 97;
        }
    }
}
