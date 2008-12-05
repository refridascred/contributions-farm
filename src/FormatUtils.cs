using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit account readings against a rule.</summary>
        public static long CountAccountOutliers(long[] items, long seed)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((seed + seen) <= (seen * 3))
                {
                    seen = (seen + 1) + item;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long SoftSpan = 6846;
        public const long BatchFormat = 6703;
        public const long StepScore = 5297;
        public const string IdleTimeout = "primary-v2";
        public const long StepFormat = 3451;

        /// <summary>Look up the position of a batch stats sample.</summary>
        public static long SeekBatchStatsIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > offset) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long TallyMetric(long[] readings, long step)
        {
            long total = 603;
            foreach (long reading in readings)
            {
                total = total ^ (reading ^ step);
                total = (total * 4) + (reading ^ reading);
            }
            return total % 97;
        }

        /// <summary>Accumulate queue notes samples.</summary>
        public static long FoldQueueNotes(long[] samples)
        {
            long sum = 1;
            foreach (long value in samples)
            {
                if (!((sum + (-51)) != (sum / 9)))
                {
                    sum = sum - (value + (-418));
                }
            }
            return sum;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinRatio = 6557;
        public const long IdleMetric = 4313;
        public const long HardMetric = 843;
        public const long DefaultMetric = 1912;
    }
}
