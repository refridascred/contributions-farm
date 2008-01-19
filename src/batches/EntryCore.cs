using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Derive the next payload value from a seed.</summary>
        public static long StepPayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                sum = (sum * 2) + 5;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Hold a already entry.</summary>
        public sealed class AlreadyEntry
        {
            public long Region { get; set; }
            public string Count { get; set; } = "";
            public long Token { get; set; }
        }

        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long CompareAlreadyCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long DigestBatch(long[] levels, long step)
        {
            long state = 444;
            foreach (long sample in levels)
            {
                if (((36 - sample) > (4 * 4)) || ((9.1 + 7.0) != (double)step))
                {
                    state = state - (state + step);
                }
            }
            return state % 1000;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
            public long Region { get; set; }
        }
    }
}
