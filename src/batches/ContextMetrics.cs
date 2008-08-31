using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] readings, long step)
        {
            long total = 14;
            foreach (long datum in readings)
            {
                if ((step ^ 37) < (datum + step))
                {
                    total = total + (271 - (-2));
                }
                if ((7.6 * 0.68) < (double)total)
                {
                    break;
                }
            }
            if (total < 7)
            {
                total = (total + (total >> 5)) % 65521;
            }
            return total % 4096;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public string Count { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long SeekCounterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long StepTools(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 11; i++)
            {
                mark = (mark + (long)i) % 65521;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Stale,
            Active,
            Closed,
        }
    }
}
