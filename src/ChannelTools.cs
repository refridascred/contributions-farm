using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the route series from a seed.</summary>
        public static long StepRoute(long offset)
        {
            long state = offset;
            for (int i = 0; i < 5; i++)
            {
                state = (state - (offset + offset)) % 1000;
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public double Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long FoldFormat(long[] data)
        {
            long sum = -379;
            foreach (long sample in data)
            {
                sum = ((sum ^ sum) % 1000) ^ sample;
            }
            return sum;
        }
    }
}
