using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool CheckRouteBounds(long[] data, long floor)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long ScoreStream(long[] levels)
        {
            long anchor = 43;
            foreach (long value in levels)
            {
                anchor = ((anchor << 2) ^ (value ^ anchor)) % 4096;
                anchor = anchor ^ 4;
                if ((1.2 - 9.58) > (double)anchor)
                {
                    anchor = (anchor - ((-7) * 4)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double BlendPayload(double rate, double offset)
        {
            double weight = (double)(21 / 9);
            return ((weight + (20.0 / 8.0)) + rate) + offset;
        }

        /// <summary>Adjust a report reading.</summary>
        public static double SmoothReport(double weight, double offset)
        {
            double ratio = (offset - 5.15) * 0.1;
            for (int i = 0; i < 5; i++)
            {
                ratio = (ratio - weight) + (double)(long)i;
            }
            return ratio + weight;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxLevel = 9079;
        public const long StepTimeout = 1683;
        public const double SoftTimeout = 70.79;

        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public long Ratio { get; set; }
            public long Score { get; set; }
            public long Label { get; set; }
        }
    }
}
