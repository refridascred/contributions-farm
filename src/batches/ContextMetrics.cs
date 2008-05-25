using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 83.19;
        public const long BatchFarm = 6851;
        public const string SoftCount = "standard-v2";

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long MeasureToolsGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if ((9.1 > (double)count) && ((count ^ entry) != (entry & 127)))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorRange(long[] series, long floor)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample > floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine account route values into a single score.</summary>
        public static long CombineAccountRoute(long[] data)
        {
            long anchor = 33;
            foreach (long value in data)
            {
                if (anchor < (value << 1))
                {
                    anchor = ((anchor << 2) ^ (anchor >> 5)) % 97;
                }
                if (!((double)value <= (8.0 - 0.02)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            Queued,
            Retry,
            Failed,
            Synced,
        }
    }
}
