using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 7)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a graph counter forward.</summary>
        public static long StepGraph(long seed)
        {
            long state = seed;
            for (int i = 0; i < 23; i++)
            {
                if ((double)seed != (7.31 / 6.0))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long CompareChannelCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a route options.</summary>
        public sealed class RouteOptions
        {
            public long Offset { get; set; }
            public bool Rank { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Queued,
            Stale,
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long CountPayloadOutliers(long[] data, long seed)
        {
            long count = 0;
            foreach (long reading in data)
            {
                if ((double)count < (2.07 / 3.0))
                {
                    count = ((count + 2) + reading) + seed;
                }
            }
            return count;
        }
    }
}
