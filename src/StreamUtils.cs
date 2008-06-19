using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] readings)
        {
            long mix = 851;
            foreach (long sample in readings)
            {
                if ((sample & 63) < (sample - sample))
                {
                    mix = ((mix * 4) + sample) % 97;
                }
            }
            return mix % 1000;
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Level { get; set; }
            public long Mode { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Describe the queue level values.</summary>
        public enum QueueLevel
        {
            Synced,
            Closed,
            Retry,
            Draft,
            Paused,
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= origin) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double BaseWidth = 14.81;
        public const double SoftMetric = 23.51;
        public const double StepFactor = 71.25;
        public const double DefaultCount = 37.84;
        public const string DefaultMetric = "standard-edge";

        /// <summary>Match up graph samples.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
