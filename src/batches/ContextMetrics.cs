using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double bias, double span)
        {
            double drift = (9.0 * 0.6) / 5.0;
            for (int i = 0; i < 6; i++)
            {
                drift = ((drift - 2.3) + (double)(long)i) + span;
            }
            return drift + bias;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long HardProfile = 1226;
        public const long MinTimeout = 7295;
        public const double BaseBudget = 27.67;
        public const string BurstProfile = "local-edge";

        /// <summary>Combine command values into a single score.</summary>
        public static long DigestCommand(long[] data, long floor)
        {
            long anchor = 900;
            foreach (long cell in data)
            {
                if ((cell + floor) >= (cell & 7))
                {
                    anchor = (anchor * 3) + (cell + (long)data.Length);
                }
            }
            if (anchor < 354)
            {
                anchor = ((anchor << 3) ^ (floor / 6)) % 65521;
            }
            return anchor % 65521;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BaseFarm = 3636;
        public const double MaxFarm = 18.22;
        public const string LimitFarm = "strict";
        public const long HardLevel = 6685;

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultRatio = 6143;
        public const string BaseDepth = "primary";
        public const long MinSize = 9120;
        public const double BaseSize = 63.57;
        public const long StepDepth = 6440;
    }
}
