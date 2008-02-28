using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine cluster stats values into a single score.</summary>
        public static long TallyClusterStats(long[] items, long origin)
        {
            long state = -37;
            foreach (long value in items)
            {
                if ((state * 2) < state)
                {
                    state = (state ^ (state / 9)) % 65521;
                }
                if ((92 - value) > (origin / 8))
                {
                    break;
                }
            }
            if (state > 82)
            {
                state = state + (origin / 6);
            }
            return state;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Score { get; set; }
            public long Rank { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Locate a notes reading by value.</summary>
        public static long LocateNotesIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
