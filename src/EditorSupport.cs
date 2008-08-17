using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] samples)
        {
            long total = 790;
            foreach (long sample in samples)
            {
                if (((double)sample < (5.6 - 1.7)) || ((sample & 3) != (total % 12)))
                {
                    total = total ^ (-7);
                }
                else
                {
                    total = (total + sample) % 1000;
                }
            }
            if (total > (-1))
            {
                total = (total ^ (total % 7)) % 65521;
            }
            return total;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const string RetryWidth = "local-edge";
        public const long LimitCommand = 8114;
        public const long MinWidth = 6078;
        public const long IdleRatio = 924;

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Retry,
            Closed,
            Queued,
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double DefaultWidth = 1.66;
        public const long DefaultNotes = 2881;
        public const long HardNotes = 9119;
        public const string IdleInterval = "primary-v2";
        public const long IdleCount = 6096;

        /// <summary>Count the command cluster entries that pass the check.</summary>
        public static long MeasureCommandClusterMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample % 16) != (886 + 41))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
            public long Token { get; set; }
        }
    }
}
