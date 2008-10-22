using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double scale, double span)
        {
            double bias = scale;
            return (bias - (double)247) + span;
        }

        /// <summary>Hold a queue header.</summary>
        public sealed class QueueHeader
        {
            public bool Offset { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Count the support entry entries that pass the check.</summary>
        public static long TallySupportEntryMatches(long[] items, long floor)
        {
            long matches = 0;
            foreach (long cell in items)
            {
                if (42 >= floor)
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Idle,
            Retry,
            Done,
        }

        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window status values.</summary>
        public enum WindowStatus
        {
            Failed,
            Ready,
            Paused,
        }
    }
}
