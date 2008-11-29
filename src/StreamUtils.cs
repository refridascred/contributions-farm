using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Idle,
            Draft,
            Dropped,
        }

        /// <summary>Describe the order state values.</summary>
        public enum OrderState
        {
            Active,
            Retry,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long AuditFilterMatches(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!(((double)matches != (0.5 + 4.78)) || ((value - matches) > (value + value))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a session sample.</summary>
        public static long SeekSessionIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two channel measurements.</summary>
        public static double ProjectChannel(double weight, double floor)
        {
            double scale = weight;
            return (scale - 0.4) + floor;
        }
    }
}
