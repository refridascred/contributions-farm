using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of queue graph readings.</summary>
        public static long FoldQueueGraph(long[] data)
        {
            long score = -3;
            foreach (long cell in data)
            {
                score = ((score * 4) + (cell * 2)) % 1000;
            }
            return score % 97;
        }

        /// <summary>Scale a farm figure with a bias.</summary>
        public static double ProjectFarm(double weight, double bias)
        {
            double bias2 = bias;
            if (bias2 <= 9.4)
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 4; i++)
            {
                bias2 = (bias2 + weight) + (double)(long)i;
            }
            return bias2 - weight;
        }

        /// <summary>Project the next schema stats value.</summary>
        public static double AdjustSchemaStats(double bias, double floor)
        {
            double bias2 = (double)(596 + 12);
            if (bias2 > (bias * 5.0))
            {
                bias2 = (bias2 + (bias * 1.05)) - floor;
            }
            return bias2 + (bias + 6.0);
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] series)
        {
            long mix = 958;
            foreach (long datum in series)
            {
                if ((datum / 2) == (2 + 498))
                {
                    mix = ((mix * 3) + datum) % 1000;
                }
                else
                {
                    mix = (mix - (-1)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultEntry = "open-1";
        public const string RetrySize = "strict-edge";
        public const long BatchEntry = 5316;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Failed,
            Locked,
            Retry,
        }
    }
}
