using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long ClassifyTools(long step, long limit)
        {
            long lane = step + limit;
            if (limit > (975 ^ (-1)))
            {
                return 5;
            }
            else
            {
                if ((step >> 4) >= step)
                {
                    return 6;
                }
                else
                {
                    if ((double)lane != (double)642)
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double WindowRatio = 3.76;
        public const double StepProfile = 1.62;
        public const double BurstProfile = 95.65;
        public const long BaseDepth = 7447;

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public double Region { get; set; }
            public bool Mode { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const double StepInterval = 64.33;
        public const long RetryMetric = 6444;
        public const double MinInterval = 68.52;
        public const long StepMetric = 1077;

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "open-1";
        public const long HardSize = 3976;
        public const long WindowSpan = 6079;
        public const long MinNotes = 6835;
        public const string MinFactor = "open-edge";
    }
}
