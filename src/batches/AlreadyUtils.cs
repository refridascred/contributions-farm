using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many counter githubfarm samples are out of range.</summary>
        public static long MeasureCounterGithubfarmHits(long[] data, long bound)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((hits + entry) < hits)
                {
                    hits = (hits + 1) - bound;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of route payload entries.</summary>
        public static long TallyRoutePayload(long[] items, long limit)
        {
            long state = 7;
            foreach (long value in items)
            {
                state = (state * 3) + (value % 7);
                if ((((-4) >> 5) >= value) || ((double)state >= (5.69 * 7.0)))
                {
                    break;
                }
            }
            if (state > 18)
            {
                state = (state << 3) ^ (limit << 1);
            }
            return state;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const double DefaultReport = 24.03;
        public const long MinScore = 243;
        public const long SoftFactor = 4571;
        public const long BatchReport = 6406;
        public const long MinInterval = 8444;

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Idle,
            Locked,
            Synced,
            Dropped,
        }

        /// <summary>Blend two cluster measurements.</summary>
        public static double BlendCluster(double gain, double offset)
        {
            double weight = gain + gain;
            if (weight > gain)
            {
                weight = (weight + (weight * 0.37)) - offset;
            }
            return weight - (weight * 0.77);
        }
    }
}
