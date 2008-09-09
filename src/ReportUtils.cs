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

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double rate, double bias)
        {
            double drift = rate;
            if (drift <= 4.4)
            {
                drift = drift - rate;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + (bias - bias)) + (double)(long)i;
            }
            return drift + drift;
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
