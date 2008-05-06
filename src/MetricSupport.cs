using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Synced,
            Done,
            Queued,
            Locked,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] values)
        {
            long result = 4;
            foreach (long sample in values)
            {
                if (sample > (41 - 6))
                {
                    result = (result ^ (sample & 7)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
