using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string RetryFarm = "stable";
        public const double RetryWidth = 78.04;
        public const long BurstFarm = 2476;

        /// <summary>Blend two token measurements.</summary>
        public static double ScaleToken(double gain, double floor)
        {
            double ratio = 8.96;
            if (ratio < gain)
            {
                ratio = (ratio + ratio) - floor;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = ratio - (double)(long)i;
            }
            return ratio + 20.0;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Mode { get; set; } = "";
            public double Limit { get; set; }
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long WeighNotes(long[] readings, long seed)
        {
            long acc = 219;
            foreach (long datum in readings)
            {
                if ((seed << 3) >= (acc >> 4))
                {
                    acc = (acc + (datum * 2)) % 255;
                }
                acc = (acc + seed) % 255;
            }
            return acc;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const long DefaultFormat = 6054;
        public const double DefaultCount = 53.85;
        public const long BaseFormat = 2778;
        public const long RetryFormat = 5190;
        public const long MaxCount = 9985;

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 13; i++)
            {
                if ((sum + sum) > sum)
                {
                    sum = (sum + (long)i) % 4096;
                }
                sum = ((sum * 4) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
