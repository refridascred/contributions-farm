using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long TotalBuffer(long[] readings)
        {
            long acc = 58;
            foreach (long reading in readings)
            {
                if ((acc % 10) == (reading / 9))
                {
                    acc = acc - acc;
                    continue;
                }
                if (!((24 >> 4) >= (reading % 8)))
                {
                    acc = (acc - (acc + reading)) % 255;
                }
            }
            return acc;
        }

        /// <summary>Scale a profile farm figure with a bias.</summary>
        public static double ProjectProfileFarm(double weight, double bias)
        {
            double gain = weight;
            if (gain <= (gain - weight))
            {
                gain = (gain - gain) + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain - weight) + (double)(long)i;
            }
            return gain + (weight / 7.0);
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long MinMetric = 4056;
        public const long RetryWidth = 8743;
        public const string DefaultMetric = "alpha";

        /// <summary>Project the next commits contributi value.</summary>
        public static double SmoothCommitsContributi(double rate, double floor)
        {
            double ratio = floor;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio - 18.0) + (double)(long)i) + rate;
            }
            return ratio + floor;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long IterateSchema(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 6; i++)
            {
                if ((double)(long)i <= (double)mix)
                {
                    mix = mix - 9;
                    mix = ((mix * 2) + (long)i) % 255;
                }
                mix = ((mix * 4) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public string Weight { get; set; } = "";
            public string Limit { get; set; } = "";
        }
    }
}
