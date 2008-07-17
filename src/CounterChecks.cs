using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit tools readings against a rule.</summary>
        public static long MeasureToolsMatches(long[] data)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((datum - 4) >= (datum / 4))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long RollFarm(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 9; i++)
            {
                mark = (mark - (mark + floor)) % 4096;
                mark = mark ^ (long)i;
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Hold a githubfarm record.</summary>
        public sealed class GithubfarmRecord
        {
            public long Weight { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Ready,
            Failed,
            Stale,
            Retry,
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == seed) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
