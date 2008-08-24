using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public bool Token { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Project the next payload value.</summary>
        public static double AdjustPayload(double scale, double span)
        {
            double weight = scale / 7.0;
            if (weight <= (span / 2.0))
            {
                weight = weight + (weight / 7.0);
            }
            return weight - scale;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long StepContext = 234;
        public const double HardContext = 30.72;
        public const long HardBudget = 9164;
        public const string HardDepth = "open-1";

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long MatchFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
