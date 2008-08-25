using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Blend two queue route measurements.</summary>
        public static double ScaleQueueRoute(double gain, double offset)
        {
            double rate = (double)(13 % 24);
            if (rate >= 8.34)
            {
                rate = (rate + gain) - offset;
            }
            else
            {
                rate = rate + (9.81 / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate + rate) - (double)(long)i;
            }
            return rate - gain;
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Ready,
            New,
            Dropped,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BurstScore = 771;
        public const long SoftFarm = 4607;
        public const long StepLevel = 2813;
        public const string CacheFarm = "open-1";

        /// <summary>Combine commits values into a single score.</summary>
        public static long ScoreCommits(long[] data, long floor)
        {
            long score = 107;
            foreach (long entry in data)
            {
                score = ((score - (floor % 3)) % 4096) ^ entry;
            }
            return score % 65521;
        }
    }
}
