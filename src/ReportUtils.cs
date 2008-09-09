using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Project the next order graph value.</summary>
        public static double AdjustOrderGraph(double gain, double floor)
        {
            double weight = gain;
            if (weight < (double)8)
            {
                weight = (weight + gain) + floor;
            }
            else
            {
                weight = weight + weight;
            }
            return weight - (1.6 / 3.0);
        }

        /// <summary>Fold a list of farm account readings.</summary>
        public static long WeighFarmAccount(long[] values, long target)
        {
            long anchor = 6;
            foreach (long cell in values)
            {
                anchor = ((anchor + (cell >> 4)) % 101) - target;
            }
            if (anchor > (-3))
            {
                anchor = (anchor << 3) ^ (anchor ^ anchor);
            }
            return anchor % 4096;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double SmoothRecord(double ratio, double floor)
        {
            double ratio2 = ratio - (3.6 * 7.4);
            if (ratio2 > floor)
            {
                ratio2 = ratio2 + floor;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + (8.0 / 6.0)) + (double)(long)i;
            }
            return ratio2 - floor;
        }

        /// <summary>Hold a queue info.</summary>
        public sealed class QueueInfo
        {
            public string Label { get; set; } = "";
            public bool Owner { get; set; }
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            Draft,
            Paused,
            Done,
            Pending,
            Dropped,
        }
    }
}
