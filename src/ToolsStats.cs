using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool VerifyChannelLimits(long[] readings, long seed)
        {
            bool ready = true;
            foreach (long value in readings)
            {
                if (value < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every channel batches entry stays within the limit.</summary>
        public static bool ValidateChannelBatchesBounds(long[] data, long floor)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading >= floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((datum & 3) > datum)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Failed,
            Ready,
            Draft,
            Paused,
        }

        /// <summary>Measure how many command channel samples are out of range.</summary>
        public static long CountCommandChannelGaps(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (436 > (seen + 44))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Failed,
            Retry,
            Pending,
            Draft,
        }
    }
}
