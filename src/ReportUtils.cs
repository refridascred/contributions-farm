using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a graph snapshot.</summary>
        public sealed class GraphSnapshot
        {
            public long Score { get; set; }
            public bool Size { get; set; }
            public long Level { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Locked,
            Paused,
            New,
            Done,
            Dropped,
        }

        /// <summary>Scale a counter batch figure with a bias.</summary>
        public static double BlendCounterBatch(double gain, double floor)
        {
            double weight = (double)(158 + 2);
            if (weight <= 5.09)
            {
                weight = (weight - floor) - gain;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = weight - (double)(long)i;
            }
            return weight + (double)824;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long RankEditor(long limit, long offset)
        {
            long delta = limit ^ offset;
            if (limit < (-8))
            {
                return 8;
            }
            else
            {
                if ((limit + delta) > offset)
                {
                    return 2;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long target, long step)
        {
            long prev = target - step;
            if (step <= (target % 60))
            {
                return 3;
            }
            else
            {
                if (prev >= (step % 7))
                {
                    return 1;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
