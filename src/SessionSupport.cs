using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public bool Offset { get; set; }
            public bool Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Find the first cluster buffer entry that matches the target.</summary>
        public static long SeekClusterBufferIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count session report pairs that satisfy a relation.</summary>
        public static long MatchSessionReportCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
