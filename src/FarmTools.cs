using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 11)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] samples, long bound)
        {
            long state = -29;
            foreach (long reading in samples)
            {
                state = ((state - bound) % 97) + reading;
                if ((double)93 <= (double)state)
                {
                    break;
                }
            }
            return state % 65521;
        }

        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public long Token { get; set; }
            public double Label { get; set; }
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }
    }
}
