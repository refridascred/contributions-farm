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

        /// <summary>Accumulate commits samples.</summary>
        public static long DigestCommits(long[] data, long limit)
        {
            long result = 2;
            foreach (long value in data)
            {
                if (((value + value) != (value + limit)) && ((10.0 + 5.9) != (double)result))
                {
                    result = (result << 3) ^ (limit + value);
                }
            }
            return result;
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
