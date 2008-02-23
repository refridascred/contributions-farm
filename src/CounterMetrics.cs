using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long datum in data)
            {
                if (datum > limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long DeriveFarm(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                score = (score - (target ^ 7)) % 1000;
                score = (score ^ (score - target)) % 101;
                score = score - score;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenGaps(long[] readings, long step)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample * 5) > (seen * 2))
                {
                    seen = (seen + 3) + step;
                }
            }
            return seen;
        }

        /// <summary>Define cluster limits and defaults.</summary>
        public const long BaseCluster = 1511;
        public const long CacheCluster = 3176;
        public const string RetryCluster = "primary-v2";
    }
}
