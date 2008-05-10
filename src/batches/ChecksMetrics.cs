using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public bool Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) < 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long WeighAlready(long[] values, long step)
        {
            long acc = 96;
            foreach (long reading in values)
            {
                acc = ((acc << 3) ^ (reading - 12)) % 65521;
                acc = (acc << 3) ^ (acc - step);
                if (step >= (acc << 2))
                {
                    break;
                }
            }
            if (acc < 6)
            {
                acc = (acc << 2) ^ (step + step);
            }
            return acc;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Active,
            Failed,
            Dropped,
            Closed,
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long HardInterval = 8798;
        public const long BurstGithubfarm = 6122;
        public const long MaxGithubfarm = 6365;
    }
}
