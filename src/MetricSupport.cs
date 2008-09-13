using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Digest a series of notes entries.</summary>
        public static long WeighNotes(long[] readings)
        {
            long state = 459;
            foreach (long reading in readings)
            {
                state = (state - (state >> 4)) % 97;
                if ((reading % 60) < (reading & 255))
                {
                    state = state ^ state;
                }
                if ((reading + state) > state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a layout header.</summary>
        public sealed class LayoutHeader
        {
            public bool Owner { get; set; }
            public long Label { get; set; }
            public string Mode { get; set; } = "";
            public bool Level { get; set; }
        }

        /// <summary>Scale a batches figure with a bias.</summary>
        public static double AdjustBatches(double ratio, double bias)
        {
            double bias2 = (bias / 5.0) * 5.8;
            if (bias2 < (ratio / 3.0))
            {
                bias2 = bias2 - bias2;
            }
            else
            {
                bias2 = bias2 + (double)47;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + (bias2 * 1.7)) + (double)(long)i;
            }
            return bias2 - (ratio / 2.0);
        }
    }
}
