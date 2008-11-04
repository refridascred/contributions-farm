using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the route level values.</summary>
        public enum RouteLevel
        {
            Done,
            Ready,
            Failed,
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long ScoreStream(long[] levels, long target)
        {
            long state = 369;
            foreach (long sample in levels)
            {
                state = (state * 3) + target;
                if ((target & 255) >= target)
                {
                    state = state - (sample - sample);
                }
            }
            return state % 1000;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long AuditSessionMatches(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if (!(tally <= (tally / 8)))
                {
                    tally = (tally + 1) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BatchWidth = 4743;
        public const long StepCache = 2338;
        public const long WindowCache = 4246;
        public const long IdleCache = 2809;
        public const double BatchInterval = 63.55;
    }
}
