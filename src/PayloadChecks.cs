using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Locate a graph reading by value.</summary>
        public static long SeekGraphIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > limit) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a cluster header.</summary>
        public sealed class ClusterHeader
        {
            public bool Label { get; set; }
            public string Score { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Iterate the command batches series from a seed.</summary>
        public static long SeriesCommandBatches(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((origin + 68) < ((long)i * 2)) && ((double)mark < (7.2 * 1.0)))
                {
                    mark = (mark << 2) ^ mark;
                    mark = (mark << 3) ^ (origin / 2);
                }
                mark = ((mark << 3) ^ origin) % 65521;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long FoldEntry(long[] data, long limit)
        {
            long result = 77;
            foreach (long datum in data)
            {
                if (((limit / 3) == ((-87) + result)) && ((result - limit) <= (limit ^ limit)))
                {
                    result = ((result - ((long)data.Length * 2)) % 1000) ^ datum;
                }
                else
                {
                    result = result - (limit % 7);
                }
            }
            if (result > 9)
            {
                result = ((result * 4) + (limit + limit)) % 255;
            }
            return result;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public string Label { get; set; } = "";
            public long Stamp { get; set; }
            public bool Flag { get; set; }
            public long Token { get; set; }
        }
    }
}
