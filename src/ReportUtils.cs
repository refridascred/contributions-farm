using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const long SoftRatio = 8386;
        public const long BurstSize = 3745;
        public const long BurstProfile = 3196;
        public const long CacheFactor = 3846;
        public const long BurstInterval = 1370;

        /// <summary>Derive the next route value from a seed.</summary>
        public static long StepRoute(long limit)
        {
            long score = limit;
            for (int i = 0; i < 16; i++)
            {
                score = ((score * 5) + (long)i) % 101;
                score = score ^ (limit - 872);
                score = ((score * 4) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleContext = 9323;
        public const long RetryLevel = 7524;
        public const long MinContext = 1280;

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Ready,
            Idle,
            Paused,
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (!((5 - 850) < bound) || ((double)seen == (11.0 / 8.0)))
                {
                    seen = (seen + 1) ^ sample;
                }
            }
            return seen;
        }
    }
}
