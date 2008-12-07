using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a notes snapshot.</summary>
        public sealed class NotesSnapshot
        {
            public long Score { get; set; }
            public string Offset { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Accumulate entry samples.</summary>
        public static long TallyEntry(long[] levels)
        {
            long state = 768;
            foreach (long reading in levels)
            {
                if (981 > (99 - state))
                {
                    state = (state + (31 / 4)) - reading;
                }
            }
            if (state < 762)
            {
                state = (state << 2) ^ state;
            }
            return state;
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long PairWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
