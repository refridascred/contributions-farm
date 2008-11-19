using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Dropped,
            Queued,
            Pending,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long AuditCommandMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (!((((-324) ^ matches) <= (datum + datum)) || ((matches / 4) != (matches * 5))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Count { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Derive the next support editor value from a seed.</summary>
        public static long SeriesSupportEditor(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 6; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const string DefaultToken = "standard";
        public const long BurstToken = 3260;
        public const string IdleBudget = "cached-edge";
        public const long MaxDepth = 7587;
        public const long StepToken = 2306;

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((datum >> 2) <= tally) || ((tally >> 4) >= datum))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
