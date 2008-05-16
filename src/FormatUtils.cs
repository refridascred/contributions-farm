using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define batch limits and defaults.</summary>
        public const long DefaultBatch = 203;
        public const double RetryBatch = 98.1;
        public const double MaxLevel = 45.39;
        public const long BurstBatch = 3479;
        public const long MaxBatch = 5860;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long floor, long offset)
        {
            long gap = floor + offset;
            if (!(floor > (gap & 31)))
            {
                return 3;
            }
            else
            {
                if ((floor ^ floor) < (gap - floor))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit contributi profile readings against a rule.</summary>
        public static long AuditContributiProfileHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches >> 5) <= (bound >> 5))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandBounds(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Score { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Compare every pair of contributi account readings.</summary>
        public static long CompareContributiAccountCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
