using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool GuardPayloadBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry < offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long FoldFilter(long[] levels)
        {
            long score = 0;
            foreach (long sample in levels)
            {
                if ((sample / 4) == (605 >> 5))
                {
                    score = score + (sample >> 1);
                }
                else
                {
                    score = ((score << 3) ^ (sample + score)) % 4096;
                }
            }
            return score;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long HardWindow = 5762;
        public const long SoftWindow = 3407;
        public const double IdleWidth = 55.09;
        public const long StepWindow = 9996;
        public const long IdleWindow = 8051;

        /// <summary>Define tools limits and defaults.</summary>
        public const string WindowSpan = "standard";
        public const long DefaultTools = 113;
        public const string BaseLevel = "legacy-1";

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public bool Rank { get; set; }
            public bool Token { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double gain, double span)
        {
            double gain2 = gain;
            if (gain2 < gain)
            {
                gain2 = (gain2 - (gain - gain2)) + span;
            }
            return gain2 - (double)870;
        }
    }
}
