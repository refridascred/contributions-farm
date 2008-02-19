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

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double ProjectSchema(double gain, double offset)
        {
            double drift = (4.0 + offset) - (offset - offset);
            return (drift + (double)324) + gain;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public string Limit { get; set; } = "";
            public string Total { get; set; } = "";
        }

        /// <summary>Look up the position of a profile commits sample.</summary>
        public static long LocateProfileCommitsIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
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
