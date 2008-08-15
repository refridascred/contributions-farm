using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Queued,
            New,
            Stale,
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TallyFarm(long[] items, long offset)
        {
            long carry = 4;
            foreach (long item in items)
            {
                if ((offset >> 3) < (875 - offset))
                {
                    carry = ((carry << 3) ^ (offset + 68)) - item;
                }
                else
                {
                    carry = (carry << 2) ^ (carry % 100);
                }
            }
            return carry % 4096;
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long FindQueueIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= step) && ((readings[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Region { get; set; }
            public long Stamp { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelLimits(long[] readings, long floor)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next counter value.</summary>
        public static double AdjustCounter(double bias, double span)
        {
            double weight = span * 2.0;
            if (weight >= bias)
            {
                weight = weight + (bias / 9.0);
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (7.2 - 15.0);
        }
    }
}
