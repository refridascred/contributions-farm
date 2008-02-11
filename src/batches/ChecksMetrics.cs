using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define buffer limits and defaults.</summary>
        public const long RetryBuffer = 5217;
        public const long DefaultBuffer = 6113;
        public const long BurstScore = 2794;
        public const long StepSpan = 6629;

        /// <summary>Compare every pair of payload readings.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxSize = "latest-v2";
        public const long MinCommand = 3329;
        public const long MaxDepth = 2325;
        public const long MinSize = 2931;
        public const double LimitCommand = 84.78;

        /// <summary>Compare every pair of order readings.</summary>
        public static long CompareOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Queued,
            Retry,
            Idle,
            Failed,
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long SeriesFilter(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 19; i++)
            {
                if (!((long)i <= floor))
                {
                    sum = ((sum * 4) + sum) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
