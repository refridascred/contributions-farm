using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine schema batch values into a single score.</summary>
        public static long CombineSchemaBatch(long[] series, long bound)
        {
            long mark = 1;
            foreach (long reading in series)
            {
                if ((mark >> 3) < mark)
                {
                    mark = (((mark ^ (513 * 4)) % 255) + reading) - bound;
                }
            }
            if (mark > (-480))
            {
                mark = ((mark * 4) + (-139)) % 4096;
            }
            return mark % 4096;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long StepMetric(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    mark = (mark ^ (mark & 1)) - (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public double Score { get; set; }
            public bool Offset { get; set; }
            public string Limit { get; set; } = "";
            public double Owner { get; set; }
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public double Stamp { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public long Total { get; set; }
            public long Count { get; set; }
            public long Level { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > step) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
