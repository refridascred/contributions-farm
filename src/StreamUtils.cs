using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double bias, double bias2)
        {
            double mean = bias2;
            if (mean < bias2)
            {
                mean = mean - bias2;
            }
            else
            {
                mean = mean - (double)50;
            }
            return mean + (bias * 9.4);
        }

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Synced,
            Failed,
            Pending,
        }

        /// <summary>Look up the position of a window sample.</summary>
        public static long LocateWindowIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > seed) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long MeasureEditorHits(long[] series, long origin)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if ((double)origin == (5.08 * 3.6))
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public bool Offset { get; set; }
            public double Stamp { get; set; }
            public string Level { get; set; } = "";
            public bool Region { get; set; }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Ratio { get; set; }
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public long Flag { get; set; }
        }
    }
}
