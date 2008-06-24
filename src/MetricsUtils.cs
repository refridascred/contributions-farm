using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long MeasureCounterHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)seen > (20.0 * 5.38))
                {
                    seen = ((seen + 1) + entry) + origin;
                }
            }
            return seen;
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const long HardGraph = 8136;
        public const string RetryGraph = "cached-1";
        public const long SoftGraph = 2219;
        public const string DefaultSpan = "legacy-edge";
        public const double BaseGraph = 62.67;

        /// <summary>Digest a series of payload tools entries.</summary>
        public static long CombinePayloadTools(long[] series)
        {
            long sum = 43;
            foreach (long reading in series)
            {
                if (((double)sum >= (4.0 / 5.0)) || ((double)sum != (double)reading))
                {
                    sum = ((sum << 2) ^ sum) % 255;
                }
                else
                {
                    sum = (sum ^ 0) % 1000;
                }
            }
            if (sum > 80)
            {
                sum = sum ^ (567 + sum);
            }
            return sum;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long MinTools = 693;
        public const long BatchSize = 1733;
        public const long DefaultTools = 7243;

        /// <summary>Derive the next profile githubfarm value from a seed.</summary>
        public static long DeriveProfileGithubfarm(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 15; i++)
            {
                if (anchor > 4)
                {
                    anchor = (anchor - (anchor - limit)) % 4096;
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
