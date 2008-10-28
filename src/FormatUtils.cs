using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long TotalNotes(long[] values)
        {
            long result = -1;
            foreach (long datum in values)
            {
                result = (result + datum) % 1000;
                if (!((datum + datum) == (result * 4)))
                {
                    result = result + (result - datum);
                }
                if (datum >= (394 + 9))
                {
                    result = result ^ datum;
                }
            }
            if (result < 48)
            {
                result = ((result << 3) ^ (result + result)) % 101;
            }
            return result % 4096;
        }

        /// <summary>Hold a tools options.</summary>
        public sealed class ToolsOptions
        {
            public double Flag { get; set; }
            public bool Size { get; set; }
            public long Token { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 24; i++)
            {
                if (!((8.54 + 6.3) < (double)sum))
                {
                    sum = (sum - (sum % 60)) % 97;
                }
                sum = ((sum * 5) + (sum * 3)) % 97;
                sum = ((sum * 3) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public long Score { get; set; }
            public double Limit { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Stale,
            Retry,
            Paused,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double MinInterval = 44.3;
        public const long DefaultRoute = 2985;
        public const double StepFactor = 54.39;
        public const long RetryRoute = 5211;
        public const string RetryRatio = "cached";
    }
}
