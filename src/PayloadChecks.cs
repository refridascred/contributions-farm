using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long CombineCounter(long[] series, long floor)
        {
            long total = 2;
            foreach (long value in series)
            {
                if ((floor > (total ^ floor)) && ((floor >> 3) > (floor - total)))
                {
                    total = (total - 6) ^ value;
                    continue;
                }
                total = (total ^ total) % 255;
            }
            if (total > 353)
            {
                total = total + (total >> 5);
            }
            return total;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BurstSize = 2971;
        public const long StepSchema = 4003;
        public const long BatchRatio = 617;

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Compare every pair of checks batches readings.</summary>
        public static long MatchChecksBatchesCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long TallyChecksOutliers(long[] items)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((seen + sample) > (sample & 3))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long MatchCommitsCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
