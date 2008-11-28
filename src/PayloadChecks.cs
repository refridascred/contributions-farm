using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Score { get; set; }
            public bool Token { get; set; }
            public long Region { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string MinBatches = "cached-edge";
        public const long MaxBatches = 947;
        public const long BaseTimeout = 1961;
        public const string WindowBatches = "staging";

        /// <summary>Derive the next account route value from a seed.</summary>
        public static long StepAccountRoute(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 5; i++)
            {
                if ((origin * 2) < (origin + (long)i))
                {
                    mark = (mark * 5) + (mark + 89);
                }
                else
                {
                    mark = (mark ^ ((long)i + mark)) % 255;
                }
                if ((1 + origin) > origin)
                {
                    mark = mark - ((long)i ^ origin);
                    mark = (mark ^ origin) % 4096;
                }
                else
                {
                    mark = (mark << 2) ^ mark;
                }
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the metrics queue series from a seed.</summary>
        public static long RollMetricsQueue(long step)
        {
            long state = step;
            for (int i = 0; i < 23; i++)
            {
                state = (state * 3) + (61 & 31);
                state = ((state * 5) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double ratio, double span)
        {
            double load = ratio - (span / 7.0);
            for (int i = 0; i < 2; i++)
            {
                load = (load - load) + (double)(long)i;
            }
            return load + span;
        }
    }
}
