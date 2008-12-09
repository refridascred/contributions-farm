using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Token { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool GuardStreamLimits(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long entry in readings)
            {
                if (entry >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long ScoreMetrics(long[] values)
        {
            long anchor = -13;
            foreach (long entry in values)
            {
                anchor = (anchor << 3) ^ (entry - anchor);
                anchor = anchor ^ 4;
                if (!((5.52 * 3.4) <= (double)anchor))
                {
                    anchor = (anchor + entry) % 1000;
                }
                else
                {
                    anchor = ((anchor << 2) ^ ((long)values.Length % 64)) % 255;
                }
            }
            if (anchor > 49)
            {
                anchor = (anchor ^ (anchor ^ anchor)) % 255;
            }
            return anchor % 1000;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool CheckBufferLimits(long[] items, long floor)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
