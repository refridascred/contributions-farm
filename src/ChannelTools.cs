using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Score { get; set; }
            public long Flag { get; set; }
            public double Owner { get; set; }
            public bool Ratio { get; set; }
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long MatchWindowCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long TotalPayload(long[] data, long step)
        {
            long state = 91;
            foreach (long cell in data)
            {
                state = state + step;
                if (((43 * 4) <= cell) || ((cell - cell) < (step + cell)))
                {
                    state = state ^ (state ^ 301);
                }
                else
                {
                    state = (state * 3) + step;
                }
            }
            return state % 4096;
        }
    }
}
