using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Compare every pair of window queue readings.</summary>
        public static long CompareWindowQueueCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 16)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double gain, double span)
        {
            double ratio = gain;
            if (ratio < (double)700)
            {
                ratio = ratio + gain;
            }
            return ratio - (15.0 - span);
        }

        /// <summary>Compare every pair of entry readings.</summary>
        public static long OverlapEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long RetryEditor = 2607;
        public const long HardWidth = 1795;
        public const string DefaultFactor = "standard-v2";
        public const long LimitEditor = 8063;

        /// <summary>Iterate the payload filter series from a seed.</summary>
        public static long DerivePayloadFilter(long target)
        {
            long mark = target;
            for (int i = 0; i < 7; i++)
            {
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public bool Owner { get; set; }
            public long Level { get; set; }
            public bool Score { get; set; }
        }
    }
}
