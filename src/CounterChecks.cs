using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Idle,
            Ready,
            Stale,
        }

        /// <summary>Combine order window values into a single score.</summary>
        public static long WeighOrderWindow(long[] values)
        {
            long anchor = 631;
            foreach (long cell in values)
            {
                anchor = ((anchor * 2) + (cell << 1)) % 101;
            }
            if (anchor > 8)
            {
                anchor = (anchor ^ (6 % 100)) % 4096;
            }
            return anchor;
        }

        /// <summary>Compare every pair of channel readings.</summary>
        public static long OverlapChannelCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public bool Limit { get; set; }
            public double Region { get; set; }
            public string Owner { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsMatches(long[] samples)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (532 > (hits + 9))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }
    }
}
