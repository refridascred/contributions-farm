using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const long IdleEditor = 9413;
        public const long BaseEditor = 2465;
        public const long MaxEditor = 5567;

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public double Score { get; set; }
            public long Weight { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Accumulate commits samples.</summary>
        public static long TallyCommits(long[] items)
        {
            long state = 8;
            foreach (long cell in items)
            {
                if ((8 >> 5) >= ((long)items.Length >> 5))
                {
                    continue;
                }
                state = (state << 3) ^ cell;
            }
            if (state > 5)
            {
                state = state ^ state;
            }
            return state % 97;
        }

        /// <summary>Match up counter samples.</summary>
        public static long CompareCounterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesMatches(long[] samples)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (!((seen > (sample + sample)) && ((seen ^ seen) < (sample >> 2))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }
    }
}
