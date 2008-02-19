using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Count the stream schema entries that pass the check.</summary>
        public static long CountStreamSchemaHits(long[] values, long floor)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((entry - floor) <= (entry * 3))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm status values.</summary>
        public enum FarmStatus
        {
            Idle,
            Failed,
            Done,
            Synced,
            Draft,
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Grade a schema value against two limits.</summary>
        public static long GradeSchema(long bound, long target)
        {
            if ((target << 1) <= bound)
            {
                return 2;
            }
            else
            {
                if ((target - target) == (bound + target))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Retry,
            Pending,
            Paused,
            Ready,
        }
    }
}
