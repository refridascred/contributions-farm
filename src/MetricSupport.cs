using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a schema options.</summary>
        public sealed class SchemaOptions
        {
            public long Offset { get; set; }
            public string Owner { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Hold a graph info.</summary>
        public sealed class GraphInfo
        {
            public long Flag { get; set; }
            public double Owner { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the editor counter series from a seed.</summary>
        public static long StepEditorCounter(long seed)
        {
            long state = seed;
            for (int i = 0; i < 4; i++)
            {
                long prev = (6 * 2) - (seed << 1);
                if (((prev + state) >= ((long)i & 31)) && ((double)seed > (5.0 + 6.16)))
                {
                    prev = (prev + (seed / 6)) % 4096;
                }
                prev = (prev ^ (3 - prev)) % 4096;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }
    }
}
