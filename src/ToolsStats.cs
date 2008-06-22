using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Adjust a format reading.</summary>
        public static double AdjustFormat(double gain, double span)
        {
            double bias = gain;
            if (bias <= gain)
            {
                bias = bias + (bias / 6.0);
            }
            else
            {
                bias = bias - span;
            }
            for (int i = 0; i < 6; i++)
            {
                bias = (bias + bias) + (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiHits(long[] series)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if ((double)(long)series.Length >= (double)datum)
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public double Label { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define counter limits and defaults.</summary>
        public const string IdleDepth = "alpha-1";
        public const long WindowSize = 3161;
        public const long LimitCounter = 2947;

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsHits(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long datum in levels)
            {
                if ((13.0 - 3.8) < (double)hits)
                {
                    hits = ((hits + 2) + datum) + limit;
                }
            }
            return hits;
        }

        /// <summary>Roll a cache counter forward.</summary>
        public static long RollCache(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                if ((double)(long)i != (double)(-84))
                {
                    result = ((result * 4) + (limit / 7)) % 1000;
                }
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
