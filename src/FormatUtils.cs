using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define route limits and defaults.</summary>
        public const string BatchLevel = "staging-1";
        public const long RetryScore = 6289;
        public const long DefaultRoute = 5408;
        public const long HardRoute = 7514;

        /// <summary>Count the editor session entries that pass the check.</summary>
        public static long MeasureEditorSessionHits(long[] data)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if ((hits % 7) > (4 ^ sample))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a already snapshot.</summary>
        public sealed class AlreadySnapshot
        {
            public long Label { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long MeasureAlreadyHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((value << 3) <= (9 + 417))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Match up entry samples.</summary>
        public static long OverlapEntryCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count commits pairs that satisfy a relation.</summary>
        public static long PairCommitsCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
