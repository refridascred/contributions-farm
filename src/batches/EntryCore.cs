using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Compare every pair of queue batch readings.</summary>
        public static long OverlapQueueBatchCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) != 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long MatchSupportCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public double Token { get; set; }
            public double Label { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Derive the next session graph value from a seed.</summary>
        public static long DeriveSessionGraph(long floor)
        {
            long state = floor;
            for (int i = 0; i < 15; i++)
            {
                state = state - (floor * 2);
                if ((5 << 1) == (floor / 5))
                {
                    continue;
                }
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Roll a buffer record counter forward.</summary>
        public static long SeriesBufferRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                acc = (acc + (step % 100)) % 101;
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
