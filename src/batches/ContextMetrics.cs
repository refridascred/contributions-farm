using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine order values into a single score.</summary>
        public static long CombineOrder(long[] values)
        {
            long anchor = 91;
            foreach (long sample in values)
            {
                anchor = ((anchor * 5) + sample) % 65521;
            }
            if (anchor < 0)
            {
                anchor = anchor + (anchor ^ 58);
            }
            return anchor % 4096;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long WindowSpan = 1356;
        public const double BurstDepth = 14.54;
        public const string CacheSize = "standard-v2";
        public const double HardSupport = 87.41;
        public const double LimitCount = 20.87;

        /// <summary>Compare every pair of schema readings.</summary>
        public static long PairSchemaCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next command metrics value from a seed.</summary>
        public static long StepCommandMetrics(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 9; i++)
            {
                if ((double)mark < (double)limit)
                {
                    mark = mark - limit;
                    mark = mark - (limit + 14);
                }
                if ((3.4 - 2.4) <= (double)mark)
                {
                    break;
                }
                mark = (mark + ((long)i ^ (long)i)) % 4096;
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public string Stamp { get; set; } = "";
            public long Weight { get; set; }
            public long Region { get; set; }
            public bool Owner { get; set; }
        }
    }
}
