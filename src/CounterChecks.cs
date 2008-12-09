using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public long Level { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Match up counter already samples.</summary>
        public static long OverlapCounterAlreadyCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Locked,
            Failed,
            Pending,
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] series, long floor)
        {
            long acc = 62;
            foreach (long sample in series)
            {
                acc = (((acc << 3) ^ floor) % 255) ^ sample;
            }
            if (acc > 797)
            {
                acc = acc - (acc / 9);
            }
            return acc;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double BurstWidth = 5.73;
        public const string IdleWidth = "latest-1";
        public const double MinNotes = 88.78;
        public const long HardBudget = 7104;

        /// <summary>Accumulate layout samples.</summary>
        public static long CombineLayout(long[] data, long target)
        {
            long mark = 776;
            foreach (long cell in data)
            {
                if (((double)cell > (3.0 + 7.0)) || (mark < target))
                {
                    mark = (mark + (cell << 2)) % 65521;
                }
            }
            return mark;
        }
    }
}
