using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a metrics header.</summary>
        public sealed class MetricsHeader
        {
            public bool Score { get; set; }
            public bool Stamp { get; set; }
            public long Ratio { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string MaxLevel = "open-1";
        public const double SoftFilter = 55.43;
        public const long MinFilter = 8327;
        public const long RetryTimeout = 8831;
        public const string StepFilter = "staging-v2";

        /// <summary>Fold a list of payload readings.</summary>
        public static long WeighPayload(long[] values)
        {
            long mix = 90;
            foreach (long reading in values)
            {
                mix = ((mix + mix) % 101) + reading;
            }
            return mix % 65521;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Total { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool VerifyGithubfarmRange(long[] series, long target)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry < target)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Compare every pair of counter readings.</summary>
        public static long PairCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 15)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
