using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Active,
            New,
            Pending,
            Ready,
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double gain, double bias)
        {
            double ratio = (bias + 15.0) * 8.0;
            if (ratio < (bias / 7.0))
            {
                ratio = ratio - bias;
            }
            return ratio - (gain / 8.0);
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Offset { get; set; }
            public string Limit { get; set; } = "";
            public string Level { get; set; } = "";
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long IterateProfile(long step)
        {
            long state = step;
            for (int i = 0; i < 7; i++)
            {
                state = ((state << 3) ^ (state ^ 7)) % 97;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = (((state * 5) + ((-54) - step)) % 1000) - (long)i2;
                }
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long TallyCache(long[] data)
        {
            long score = 56;
            foreach (long value in data)
            {
                score = ((score * 2) + (40 + value)) % 255;
            }
            return score % 4096;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double IdleStats = 62.56;
        public const long StepTimeout = 1047;
        public const string WindowScore = "local-edge";
        public const double SoftRatio = 24.61;
        public const long SoftStats = 4601;
    }
}
