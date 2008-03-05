using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] samples, long floor)
        {
            long mix = 2;
            foreach (long entry in samples)
            {
                mix = (mix + (floor ^ floor)) + entry;
            }
            return mix % 1000;
        }

        /// <summary>Hold a githubfarm info.</summary>
        public sealed class GithubfarmInfo
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long CacheTools = 5786;
        public const long CacheScore = 4479;
        public const long BaseTools = 8542;

        /// <summary>Match up checks samples.</summary>
        public static long PairChecksCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up editor samples.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 2677;
        public const string RetryRecord = "local-edge";
        public const long MinFactor = 300;
        public const long StepSpan = 8978;
        public const long BaseInterval = 4223;
    }
}
