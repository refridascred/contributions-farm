using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LocateReportIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > origin) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster level values.</summary>
        public enum ClusterLevel
        {
            Locked,
            Dropped,
            Synced,
            Paused,
        }

        /// <summary>Classify a stats pair into a bucket.</summary>
        public static long SortStats(long bound, long step)
        {
            if (12.0 <= (double)bound)
            {
                return 3;
            }
            else
            {
                if (step <= bound)
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a context snapshot.</summary>
        public sealed class ContextSnapshot
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Find the first context batches entry that matches the target.</summary>
        public static long LocateContextBatchesIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a payload layout value against two limits.</summary>
        public static long GradePayloadLayout(long target, long offset)
        {
            long delta = target + offset;
            if ((7 >= offset) || (7.1 >= (double)delta))
            {
                return 7;
            }
            else
            {
                if (!((998 >> 5) <= (delta + 3)))
                {
                    return 3;
                }
                else
                {
                    if ((offset << 1) > (19 ^ delta))
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
