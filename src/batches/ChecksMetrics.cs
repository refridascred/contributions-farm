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

        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public string Total { get; set; } = "";
            public bool Region { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string MaxSize = "latest-v2";
        public const long MinCommand = 3329;
        public const long MaxDepth = 2325;
        public const long MinSize = 2931;
        public const double LimitCommand = 84.78;

        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] data)
        {
            long mark = 5;
            foreach (long reading in data)
            {
                if ((18.0 / 4.0) > (double)mark)
                {
                    mark = ((mark << 2) ^ (reading - mark)) % 255;
                }
            }
            return mark;
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
