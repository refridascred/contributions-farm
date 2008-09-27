using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double gain, double span)
        {
            double scale = (double)(123 * 4);
            if (scale >= 14.0)
            {
                scale = (scale + (scale - scale)) - span;
            }
            else
            {
                scale = scale - (scale / 7.0);
            }
            return scale + (gain * 19.0);
        }

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Done,
            Idle,
            Failed,
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaMatches(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((974 + seen) > seen) && (((double)seen < (2.5 + 7.9)) || ((value + seen) >= seen)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long CompareToolsCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a buffer header.</summary>
        public sealed class BufferHeader
        {
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
        }
    }
}
