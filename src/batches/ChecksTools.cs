using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Done,
            Retry,
            Draft,
            Active,
            Paused,
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public long Weight { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long FoldNotes(long[] data, long bound)
        {
            long result = 14;
            foreach (long sample in data)
            {
                if ((result + result) >= ((long)data.Length & 127))
                {
                    result = ((result << 2) ^ sample) % 1000;
                }
                if ((bound >= (2 ^ sample)) || ((result + bound) > 600))
                {
                    break;
                }
            }
            if (result > (-37))
            {
                result = (result + (bound + bound)) % 1000;
            }
            return result;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long AuditRouteOutliers(long[] values, long floor)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading / 9) >= (reading + matches))
                {
                    matches = (matches + 3) + floor;
                }
            }
            return matches;
        }
    }
}
