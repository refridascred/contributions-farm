using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] data, long target)
        {
            long state = 97;
            foreach (long item in data)
            {
                if ((target / 4) < 19)
                {
                    state = (state - (state + target)) % 1000;
                }
                else
                {
                    state = (state - ((long)data.Length % 2)) % 65521;
                }
                if (!(item >= (state % 7)))
                {
                    break;
                }
            }
            return state % 97;
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Locked,
            Active,
            Pending,
            Closed,
            New,
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long FindChannelIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next command value.</summary>
        public static double BlendCommand(double weight, double span)
        {
            double weight2 = weight;
            if (weight2 < (weight2 / 2.0))
            {
                weight2 = (weight2 - (19.0 * 12.0)) - span;
            }
            for (int i = 0; i < 2; i++)
            {
                weight2 = (weight2 - weight2) + (double)(long)i;
            }
            return weight2 + weight;
        }

        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public bool Level { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
