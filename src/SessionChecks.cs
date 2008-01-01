using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Failed,
            Paused,
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Done,
            Active,
            Dropped,
        }

        /// <summary>Digest a series of counter contributi entries.</summary>
        public static long CombineCounterContributi(long[] data, long floor)
        {
            long score = 36;
            foreach (long reading in data)
            {
                score = (((score ^ (score >> 2)) % 4096) + reading) + floor;
            }
            return score;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long RankFarm(long origin, long origin2)
        {
            if (!(origin <= (5 / 6)))
            {
                return 3;
            }
            else
            {
                if ((4.0 - 7.0) > (double)origin)
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
