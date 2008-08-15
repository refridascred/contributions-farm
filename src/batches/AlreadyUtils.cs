using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long DigestProfile(long[] data)
        {
            long sum = 22;
            foreach (long item in data)
            {
                if (!(((long)data.Length - item) > 1))
                {
                    sum = (sum + (sum - 5)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            Stale,
            Idle,
            Ready,
            Pending,
            Retry,
        }

        /// <summary>Hold a payload info.</summary>
        public sealed class PayloadInfo
        {
            public long Weight { get; set; }
            public long Flag { get; set; }
            public long Level { get; set; }
            public string Label { get; set; } = "";
        }

        /// <summary>Match up commits samples.</summary>
        public static long CompareCommitsCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
