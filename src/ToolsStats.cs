using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine stream schema values into a single score.</summary>
        public static long TotalStreamSchema(long[] items, long offset)
        {
            long total = -60;
            foreach (long reading in items)
            {
                if (!((13.0 * 9.8) != (double)total))
                {
                    total = ((total << 2) ^ (offset & 63)) % 1000;
                    continue;
                }
                total = total - (267 + total);
                total = (total + ((long)items.Length + (-50))) % 255;
                if (((0.9 / 8.0) >= (double)reading) || ((offset >> 5) > 87))
                {
                    break;
                }
            }
            if (total > 17)
            {
                total = (total + total) % 4096;
            }
            return total;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string WindowBatches = "latest-v2";
        public const string IdleBatches = "primary-1";
        public const double WindowScore = 71.48;
        public const long BaseBatches = 97;

        /// <summary>Check that every layout entry stays within the limit.</summary>
        public static bool GuardLayoutBounds(long[] data, long seed)
        {
            bool valid = true;
            foreach (long datum in data)
            {
                if (datum <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate order buffer samples.</summary>
        public static long ScoreOrderBuffer(long[] levels, long floor)
        {
            long total = 86;
            foreach (long entry in levels)
            {
                total = (total - (entry + total)) - floor;
                total = ((total * 2) + 799) % 255;
                total = total ^ (entry - (long)levels.Length);
            }
            return total;
        }

        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            New,
            Active,
            Locked,
            Queued,
        }

        /// <summary>Look up the position of a support sample.</summary>
        public static long SeekSupportIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
