using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftSpan = 820;
        public const long BurstWidth = 5884;
        public const long IdleFilter = 1545;
        public const string BaseFactor = "alpha";
        public const long WindowFilter = 4000;

        /// <summary>Locate a tools reading by value.</summary>
        public static long FindToolsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter summary.</summary>
        public sealed class CounterSummary
        {
            public long Flag { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Project the next context value.</summary>
        public static double ScaleContext(double scale, double bias)
        {
            double ratio = (scale * 6.2) / 7.0;
            if (ratio < scale)
            {
                ratio = (ratio - (double)631) - bias;
            }
            return ratio + (double)85;
        }

        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public long Score { get; set; }
            public bool Region { get; set; }
            public long Count { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Check that every session schema entry stays within the limit.</summary>
        public static bool GuardSessionSchemaRange(long[] readings, long origin)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
