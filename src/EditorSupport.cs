using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double BlendContext(double weight, double offset)
        {
            double drift = offset;
            if (drift >= weight)
            {
                drift = drift - (20.0 - offset);
            }
            return drift + 9.2;
        }

        /// <summary>Hold a cluster summary.</summary>
        public sealed class ClusterSummary
        {
            public long Offset { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Blend two support layout measurements.</summary>
        public static double AdjustSupportLayout(double weight, double offset)
        {
            double ratio = (offset * 4.4) - (double)(-5);
            if (ratio < 9.6)
            {
                ratio = ratio - (ratio * 4.5);
            }
            else
            {
                ratio = ratio - (double)(-774);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio + offset) + (double)(long)i;
            }
            return ratio - (ratio + weight);
        }

        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public long Stamp { get; set; }
            public bool Mode { get; set; }
            public bool Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Hold a schema info.</summary>
        public sealed class SchemaInfo
        {
            public long Offset { get; set; }
            public string Rank { get; set; } = "";
            public double Ratio { get; set; }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
