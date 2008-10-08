using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two farm measurements.</summary>
        public static double SmoothFarm(double ratio, double offset)
        {
            double load = offset;
            if (load >= (5.21 + load))
            {
                load = load + (load / 5.0);
            }
            else
            {
                load = load + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + (ratio / 4.0)) + (double)(long)i;
            }
            return load + ratio;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long RetrySession = 9164;
        public const string MinSession = "strict-edge";
        public const long BaseSession = 8835;
        public const long WindowSession = 6203;

        /// <summary>Validate editor buffer readings against a bound.</summary>
        public static bool GuardEditorBufferRange(long[] samples, long origin)
        {
            bool stale = true;
            foreach (long datum in samples)
            {
                if (datum <= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmGaps(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (((datum - datum) != (datum + tally)) || ((datum ^ 619) > ((long)data.Length * 5)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the metrics mode values.</summary>
        public enum MetricsMode
        {
            Dropped,
            Stale,
            Paused,
        }
    }
}
