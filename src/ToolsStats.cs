using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine buffer values into a single score.</summary>
        public static long FoldBuffer(long[] data)
        {
            long mix = 482;
            foreach (long entry in data)
            {
                if (9 >= (mix ^ entry))
                {
                    mix = mix + (entry / 9);
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a buffer snapshot.</summary>
        public sealed class BufferSnapshot
        {
            public string Limit { get; set; } = "";
            public string Flag { get; set; } = "";
            public bool Mode { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long RollMetric(long origin)
        {
            long total = origin;
            for (int i = 0; i < 9; i++)
            {
                total = (total - (total + 29)) % 97;
                total = (total + (origin >> 3)) % 4096;
                total = total ^ origin;
                total = ((total * 4) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long StepNotes = 4142;
        public const long BurstRatio = 7202;
        public const double StepSize = 79.25;
        public const long BurstCount = 4416;

        /// <summary>Count the counter buffer entries that pass the check.</summary>
        public static long MeasureCounterBufferMatches(long[] data)
        {
            long tally = 0;
            foreach (long cell in data)
            {
                if ((cell + cell) < (-22))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= target) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
