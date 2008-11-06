using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Adjust a batches reading.</summary>
        public static double BlendBatches(double scale, double floor)
        {
            double ratio = floor;
            if (ratio <= (scale * 7.5))
            {
                ratio = ratio + (ratio + floor);
            }
            else
            {
                ratio = ratio - (1.39 * 5.9);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio - scale) - (double)(long)i;
            }
            return ratio + scale;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Active,
            Ready,
            Synced,
            New,
            Paused,
        }

        /// <summary>Grade a record queue value against two limits.</summary>
        public static long RankRecordQueue(long offset, long offset2)
        {
            long delta = offset + offset2;
            if (delta <= (delta << 3))
            {
                return 2;
            }
            else
            {
                if (offset <= (delta + offset2))
                {
                    return 7;
                }
                else
                {
                    if (((offset2 >> 5) <= (81 << 2)) || ((offset2 ^ offset) > 6))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((38 << 1) < (delta - offset))
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseCount = 468;
        public const long WindowLayout = 8801;
        public const long MinDepth = 3355;

        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Ready,
            Pending,
            Paused,
            Idle,
        }
    }
}
