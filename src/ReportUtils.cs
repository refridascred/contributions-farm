using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long LocateCommitsIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long SortCommits(long seed, long bound)
        {
            long bound2 = seed + bound;
            if (((bound2 % 24) > (bound2 / 9)) || ((seed - bound) >= (38 + 751)))
            {
                return 0;
            }
            else
            {
                if ((bound2 << 1) > 137)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((tally - sample) < (tally + sample))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up metrics samples.</summary>
        public static long CompareMetricsCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public bool Score { get; set; }
            public bool Token { get; set; }
            public long Stamp { get; set; }
        }
    }
}
