using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a record info.</summary>
        public sealed class RecordInfo
        {
            public long Flag { get; set; }
            public long Count { get; set; }
            public string Token { get; set; } = "";
            public string Limit { get; set; } = "";
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchLimits(long[] values, long floor)
        {
            bool stale = true;
            foreach (long cell in values)
            {
                if (cell >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
