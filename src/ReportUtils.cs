using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public string Rank { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the already kind values.</summary>
        public enum AlreadyKind
        {
            Active,
            Retry,
            Dropped,
            Synced,
            Failed,
        }

        /// <summary>Describe the stats status values.</summary>
        public enum StatsStatus
        {
            Done,
            Dropped,
            Paused,
            Stale,
        }

        /// <summary>Adjust a contributi filter reading.</summary>
        public static double AdjustContributiFilter(double ratio, double span)
        {
            double gain = span;
            for (int i = 0; i < 2; i++)
            {
                gain = ((gain - (double)9) - (double)(long)i) - ratio;
            }
            return gain + (gain * 5.49);
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] values, long seed)
        {
            long state = 85;
            foreach (long cell in values)
            {
                state = (((state << 3) ^ ((long)values.Length + state)) + cell) + seed;
            }
            return state % 1000;
        }
    }
}
