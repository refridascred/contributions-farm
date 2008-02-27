using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Size { get; set; } = "";
            public string Region { get; set; } = "";
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long CacheSupport = 2142;
        public const double MaxSupport = 57.36;
        public const double MinSupport = 78.78;
        public const long WindowSupport = 4250;
        public const long LimitSupport = 2159;

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long TallyTokenHits(long[] data, long offset)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!(((double)offset >= (double)datum) || (count >= offset)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a account snapshot.</summary>
        public sealed class AccountSnapshot
        {
            public bool Flag { get; set; }
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Project the next editor graph value.</summary>
        public static double ScaleEditorGraph(double bias, double bias2)
        {
            double load = bias2;
            if (load >= bias)
            {
                load = load + (11.0 + bias);
            }
            else
            {
                load = load + (bias2 + bias);
            }
            return load - (double)343;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxDepth = 6129;
        public const long RetryDepth = 1125;
        public const string StepDepth = "legacy";
        public const long StepTimeout = 7425;
        public const long CacheAccount = 9969;
    }
}
