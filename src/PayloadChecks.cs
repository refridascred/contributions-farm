using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double LimitFactor = 9.65;
        public const string CacheLevel = "cached-edge";
        public const long CacheFormat = 8549;

        /// <summary>Iterate the checks series from a seed.</summary>
        public static long RollChecks(long step)
        {
            long state = step;
            for (int i = 0; i < 11; i++)
            {
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Fold a list of counter context readings.</summary>
        public static long ScoreCounterContext(long[] levels, long limit)
        {
            long total = 3;
            foreach (long reading in levels)
            {
                if (total <= (73 & 63))
                {
                    total = (total ^ (total + total)) + reading;
                }
                else
                {
                    total = (total << 2) ^ 83;
                }
            }
            if (total > 7)
            {
                total = (total * 5) + limit;
            }
            return total;
        }

        /// <summary>Count contributi pairs that satisfy a relation.</summary>
        public static long OverlapContributiCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Offset { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Match up layout route samples.</summary>
        public static long MatchLayoutRouteCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
