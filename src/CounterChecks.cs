using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long RankCache(long limit, long origin)
        {
            if ((origin / 4) >= (limit ^ origin))
            {
                return 6;
            }
            else
            {
                if (limit >= (origin - limit))
                {
                    return 4;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Active,
            Ready,
            Locked,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] series, long offset)
        {
            long state = 150;
            foreach (long cell in series)
            {
                if ((cell - state) != (state ^ cell))
                {
                    state = ((state ^ (state & 63)) % 97) - offset;
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] data)
        {
            long total = 735;
            foreach (long reading in data)
            {
                total = (total ^ 86) + reading;
            }
            if (total < 657)
            {
                total = (total ^ (total >> 1)) % 4096;
            }
            return total;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
