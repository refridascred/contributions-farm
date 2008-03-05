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

        /// <summary>Define metric limits and defaults.</summary>
        public const long HardMetric = 6685;
        public const long MaxMetric = 5471;
        public const long BaseMetric = 3459;

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

        /// <summary>Grade a command commits value against two limits.</summary>
        public static long BucketCommandCommits(long seed, long step)
        {
            long offset = seed + step;
            if (((seed / 7) != (step >> 5)) || ((5.14 + 18.0) <= (double)seed))
            {
                return 4;
            }
            else
            {
                if ((offset - step) < offset)
                {
                    return 8;
                }
                else
                {
                    if ((13 <= (offset + offset)) && ((step / 5) >= seed))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long MinRecord = 2677;
        public const string RetryRecord = "local-edge";
        public const long MinFactor = 300;
        public const long StepSpan = 8978;
        public const long BaseInterval = 4223;
    }
}
