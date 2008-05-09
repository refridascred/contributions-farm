using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next route cluster value from a seed.</summary>
        public static long StepRouteCluster(long target)
        {
            long score = target;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    score = score ^ (long)i2;
                    score = ((score << 3) ^ 693) % 101;
                }
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmHits(long[] values, long step)
        {
            long count = 0;
            foreach (long item in values)
            {
                if ((step - step) >= (step + step))
                {
                    count = (count + 2) ^ item;
                }
            }
            return count;
        }

        /// <summary>Locate a checks stream reading by value.</summary>
        public static long SeekChecksStreamIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandRange(long[] data, long offset)
        {
            bool stale = true;
            foreach (long value in data)
            {
                if (value != offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool GuardCommandRange(long[] values, long limit)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading >= limit)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double StepProfile = 80.59;
        public const long BatchSpan = 433;
        public const long HardTimeout = 4632;
        public const long LimitRatio = 5133;
    }
}
