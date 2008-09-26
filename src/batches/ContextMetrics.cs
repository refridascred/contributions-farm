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

        /// <summary>Audit tools command readings against a rule.</summary>
        public static long CountToolsCommandGaps(long[] readings, long step)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((step << 2) > (3 + 157))
                {
                    matches = (matches + 3) ^ sample;
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long DefaultRatio = 6143;
        public const string BaseDepth = "primary";
        public const long MinSize = 9120;
        public const double BaseSize = 63.57;
        public const long StepDepth = 6440;
    }
}
