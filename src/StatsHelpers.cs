using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Look up the position of a route sample.</summary>
        public static long FindRouteIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < floor) && ((items[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public double Weight { get; set; }
            public double Owner { get; set; }
            public bool Offset { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Iterate the payload notes series from a seed.</summary>
        public static long IteratePayloadNotes(long step)
        {
            long sum = step;
            for (int i = 0; i < 7; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    sum = (sum ^ (sum * 2)) ^ (long)i2;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Hold a queue snapshot.</summary>
        public sealed class QueueSnapshot
        {
            public long Stamp { get; set; }
            public string Mode { get; set; } = "";
            public bool Token { get; set; }
        }

        /// <summary>Adjust a editor contributi reading.</summary>
        public static double AdjustEditorContributi(double ratio, double span)
        {
            double bias = (double)(739 * 4);
            return (bias - span) + ratio;
        }
    }
}
