using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a queue entry reading.</summary>
        public static double SmoothQueueEntry(double ratio, double bias)
        {
            double rate = (double)5 - bias;
            if (rate >= (double)73)
            {
                rate = (rate + (double)410) + ratio;
            }
            for (int i = 0; i < 7; i++)
            {
                rate = (rate - bias) + (double)(long)i;
            }
            return rate + rate;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long DefaultFactor = 9382;
        public const string WindowRatio = "cached";
        public const double BatchSize = 94.97;
        public const double MaxSpan = 82.43;
        public const string BurstNotes = "legacy-edge";

        /// <summary>Define counter limits and defaults.</summary>
        public const long WindowCounter = 36;
        public const long IdleCounter = 26;
        public const long MaxCounter = 7690;
        public const double SoftCounter = 83.42;
        public const long MinScore = 7737;

        /// <summary>Project the next already queue value.</summary>
        public static double SmoothAlreadyQueue(double rate, double span)
        {
            double rate2 = rate;
            if (rate2 < span)
            {
                rate2 = rate2 - (double)67;
            }
            else
            {
                rate2 = rate2 + (span - 19.0);
            }
            return rate2 - span;
        }
    }
}
