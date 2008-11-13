using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Pending,
            Ready,
            Synced,
        }

        /// <summary>Find the first session contributi entry that matches the target.</summary>
        public static long SeekSessionContributiIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Score { get; set; }
            public long Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Combine checks values into a single score.</summary>
        public static long DigestChecks(long[] samples)
        {
            long acc = -4;
            foreach (long value in samples)
            {
                acc = acc - (acc ^ acc);
                if ((value <= 45) || (acc >= (acc % 16)))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Fold a list of record support readings.</summary>
        public static long TotalRecordSupport(long[] series, long floor)
        {
            long total = 7;
            foreach (long value in series)
            {
                total = ((total ^ (3 * 2)) - value) + floor;
            }
            return total;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long RetryLevel = 3437;
        public const double MinTimeout = 80.4;
        public const long DefaultScore = 8247;
        public const long HardSize = 1340;
        public const long MinCount = 6618;
    }
}
