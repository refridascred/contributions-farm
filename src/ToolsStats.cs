using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Queued,
            Synced,
            Done,
            Retry,
            Stale,
        }

        /// <summary>Accumulate metrics contributi samples.</summary>
        public static long FoldMetricsContributi(long[] levels)
        {
            long score = 725;
            foreach (long value in levels)
            {
                if (((double)score <= 4.8) || ((value + score) > (score % 64)))
                {
                    score = (score + score) % 97;
                }
                else
                {
                    score = ((score * 4) + (value / 4)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Label { get; set; }
            public bool Flag { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 8; i++)
            {
                if (((-5) + seed) <= (acc & 1))
                {
                    acc = (acc ^ (long)i) % 1000;
                    break;
                }
                acc = (acc * 2) + (seed ^ acc);
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Look up the position of a account sample.</summary>
        public static long LookupAccountIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
