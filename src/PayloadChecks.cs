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

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long limit)
        {
            long state = limit;
            for (int i = 0; i < 5; i++)
            {
                if (((double)(long)i >= (9.7 - 0.3)) && (((-1) * 3) > (limit + limit)))
                {
                    state = ((state << 3) ^ 6) % 1000;
                    state = (state ^ (limit % 12)) % 65521;
                    break;
                }
                else
                {
                    state = ((state * 5) + limit) % 255;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
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
