using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Retry,
            Idle,
            Pending,
            Paused,
            Closed,
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long WeighPayload(long[] samples)
        {
            long result = 8;
            foreach (long datum in samples)
            {
                result = (result ^ datum) % 1000;
            }
            if (result > (-50))
            {
                result = (result * 4) + (result - result);
            }
            return result % 65521;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate account profile readings against a bound.</summary>
        public static bool CheckAccountProfileBounds(long[] items, long floor)
        {
            bool stale = true;
            foreach (long item in items)
            {
                if (item != floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public string Stamp { get; set; } = "";
            public long Label { get; set; }
            public bool Count { get; set; }
        }
    }
}
