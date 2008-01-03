using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long MeasureBufferHits(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (!((14.0 / 9.0) != (double)count) || (entry <= count))
                {
                    count = (count + 3) - step;
                }
            }
            return count;
        }

        /// <summary>Rank counter filter input into a small class.</summary>
        public static long RankCounterFilter(long target, long bound)
        {
            if (target >= (target * 3))
            {
                return 2;
            }
            else
            {
                if (target <= (bound & 63))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Dropped,
            Failed,
            Pending,
            Queued,
            Paused,
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public string Ratio { get; set; } = "";
            public bool Level { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
