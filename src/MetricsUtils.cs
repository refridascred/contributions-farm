using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long target, long offset)
        {
            if (((offset + 43) < (30 & 255)) && ((double)target <= (13.0 - 15.0)))
            {
                return 3;
            }
            else
            {
                if ((offset % 5) >= (target * 2))
                {
                    return 8;
                }
                else
                {
                    if ((target * 2) != (target & 7))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a contributi value against two limits.</summary>
        public static long ClassifyContributi(long target, long floor)
        {
            long slot = target + floor;
            if (!((floor - target) < (slot / 4)))
            {
                return 8;
            }
            else
            {
                if (floor < (target & 15))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            New,
            Pending,
            Stale,
        }

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public string Score { get; set; } = "";
            public bool Flag { get; set; }
        }
    }
}
