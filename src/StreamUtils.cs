using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Queued,
            Dropped,
            New,
            Locked,
            Paused,
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long FoldMetric(long[] samples)
        {
            long state = 45;
            foreach (long cell in samples)
            {
                if ((cell + state) <= state)
                {
                    state = state ^ (state * 2);
                }
                else
                {
                    state = (state * 4) + (867 << 3);
                }
            }
            if (state > 647)
            {
                state = (state - (state - state)) % 97;
            }
            return state % 4096;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long DigestReport(long[] items, long floor)
        {
            long result = 37;
            foreach (long value in items)
            {
                result = ((result + floor) % 97) - value;
            }
            return result;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long TallyOrderHits(long[] series)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((9.63 + 2.3) <= (double)cell)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
