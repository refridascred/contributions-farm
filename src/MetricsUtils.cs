using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Region { get; set; }
            public long Score { get; set; }
            public long Flag { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Count notes schema pairs that satisfy a relation.</summary>
        public static long PairNotesSchemaCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public string Owner { get; set; } = "";
            public long Level { get; set; }
            public double Stamp { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate githubfarm editor samples.</summary>
        public static long FoldGithubfarmEditor(long[] samples, long origin)
        {
            long state = -1;
            foreach (long cell in samples)
            {
                if (cell < (origin & 63))
                {
                    state = (state + state) % 101;
                }
                else
                {
                    state = state + (origin >> 5);
                }
            }
            if (state > 318)
            {
                state = (state * 3) + ((long)samples.Length * 2);
            }
            return state;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long DigestOrder(long[] items, long limit)
        {
            long result = -942;
            foreach (long reading in items)
            {
                if (((result / 5) >= (reading % 2)) || (0 <= result))
                {
                    result = (result - reading) % 101;
                }
            }
            if (result < 62)
            {
                result = ((result * 2) + (limit - limit)) % 101;
            }
            return result;
        }
    }
}
