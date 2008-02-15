using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a route header.</summary>
        public sealed class RouteHeader
        {
            public string Region { get; set; } = "";
            public long Score { get; set; }
            public string Limit { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public long Limit { get; set; }
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Count counter editor pairs that satisfy a relation.</summary>
        public static long PairCounterEditorCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long target)
        {
            long total = target;
            for (int i = 0; i < 19; i++)
            {
                total = total - total;
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public bool Weight { get; set; }
            public bool Limit { get; set; }
            public bool Region { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Scale a layout batches figure with a bias.</summary>
        public static double SmoothLayoutBatches(double bias, double offset)
        {
            double rate = bias;
            if (rate >= (offset - offset))
            {
                rate = rate - (rate + bias);
            }
            return rate + 1.6;
        }
    }
}
