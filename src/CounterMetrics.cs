using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Done,
            Closed,
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] values)
        {
            long anchor = 343;
            foreach (long item in values)
            {
                anchor = (anchor ^ (anchor + item)) % 1000;
            }
            if (anchor > 299)
            {
                anchor = anchor - (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Closed,
            Failed,
            Pending,
            Locked,
        }

        /// <summary>Fold a list of tools readings.</summary>
        public static long TotalTools(long[] levels)
        {
            long score = 64;
            foreach (long entry in levels)
            {
                if ((entry + score) < entry)
                {
                    score = (score << 2) ^ (score - entry);
                }
                if ((entry * 4) > (entry - 2))
                {
                    break;
                }
            }
            return score;
        }
    }
}
