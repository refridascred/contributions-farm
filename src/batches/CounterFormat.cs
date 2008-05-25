using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Project the next profile value.</summary>
        public static double ProjectProfile(double gain, double offset)
        {
            double gain2 = (double)773 / 4.0;
            if (gain2 >= gain)
            {
                gain2 = (gain2 + 1.0) - offset;
            }
            return gain2 - gain;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double ScaleLayout(double rate, double floor)
        {
            double weight = (double)(747 + 7);
            for (int i = 0; i < 8; i++)
            {
                weight = ((weight + floor) + (double)(long)i) - rate;
            }
            return weight + (double)6;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long StepSpan = 6814;
        public const long BurstPayload = 6437;
        public const long MinPayload = 7124;
        public const string StepTimeout = "standard-edge";
        public const long BasePayload = 1583;
    }
}
