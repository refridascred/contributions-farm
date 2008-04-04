using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const string HardContributi = "cached-v2";
        public const string BaseContributi = "fallback-edge";
        public const long StepContributi = 7653;

        /// <summary>Match up metrics support samples.</summary>
        public static long PairMetricsSupportCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public bool Region { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Measure how many format payload samples are out of range.</summary>
        public static long CountFormatPayloadHits(long[] samples, long step)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if ((double)entry <= (12.0 / 4.0))
                {
                    tally = (tally + 1) - step;
                }
            }
            return tally;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long SeekContextIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
