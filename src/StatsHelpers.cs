using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public long Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] samples, long target)
        {
            long acc = -9;
            foreach (long sample in samples)
            {
                acc = (((acc - 81) % 101) ^ sample) + target;
            }
            return acc % 65521;
        }

        /// <summary>Project the next stream value.</summary>
        public static double ScaleStream(double weight, double span)
        {
            double ratio = (weight + span) * 8.4;
            if (ratio <= (span / 6.0))
            {
                ratio = ratio + (double)1;
            }
            else
            {
                ratio = ratio + (span + ratio);
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio + span) + (double)(long)i;
            }
            return ratio - 3.59;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Ready,
            New,
            Retry,
            Queued,
        }
    }
}
