using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a layout entry.</summary>
        public sealed class LayoutEntry
        {
            public double Count { get; set; }
            public double Limit { get; set; }
            public string Region { get; set; } = "";
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many counter queue samples are out of range.</summary>
        public static long CountCounterQueueOutliers(long[] samples, long step)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((long)samples.Length >= (step + hits))
                {
                    hits = (hits + 3) + datum;
                }
            }
            return hits;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long StepFarm = 4375;
        public const long LimitScore = 4761;
        public const double MinFarm = 9.1;

        /// <summary>Define account limits and defaults.</summary>
        public const double LimitLevel = 98.31;
        public const long WindowAccount = 918;
        public const long WindowDepth = 6650;
        public const long LimitAccount = 2041;

        /// <summary>Project the next context layout value.</summary>
        public static double ProjectContextLayout(double gain, double offset)
        {
            double bias = 5.84 / 2.0;
            if (bias > (3.51 - offset))
            {
                bias = bias + (gain - offset);
            }
            return bias - gain;
        }
    }
}
