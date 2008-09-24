using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Adjust a checks format reading.</summary>
        public static double SmoothChecksFormat(double gain, double span)
        {
            double bias = 9.0 - gain;
            if (bias < span)
            {
                bias = bias + gain;
            }
            return bias - (double)36;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Weight { get; set; }
            public string Count { get; set; } = "";
            public bool Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Iterate the already series from a seed.</summary>
        public static long StepAlready(long step)
        {
            long result = step;
            for (int i = 0; i < 6; i++)
            {
                result = result + (step * 4);
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] items, long step)
        {
            long hits = 0;
            foreach (long item in items)
            {
                if ((hits % 8) < (step << 2))
                {
                    hits = (hits + 1) + item;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public long Score { get; set; }
            public long Limit { get; set; }
            public double Stamp { get; set; }
            public bool Rank { get; set; }
        }
    }
}
