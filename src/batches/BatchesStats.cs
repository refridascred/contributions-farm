using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of layout metric entries.</summary>
        public static long WeighLayoutMetric(long[] samples)
        {
            long acc = 73;
            foreach (long datum in samples)
            {
                if ((datum >> 5) != (datum >> 4))
                {
                    acc = ((acc << 2) ^ acc) % 4096;
                }
                else
                {
                    acc = acc + (2 ^ acc);
                }
            }
            return acc;
        }

        /// <summary>Compare every pair of already readings.</summary>
        public static long MatchAlreadyCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Failed,
            Ready,
            Retry,
            Closed,
            Draft,
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorGaps(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((offset - seen) != (seen + reading))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
