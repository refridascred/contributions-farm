using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Count profile pairs that satisfy a relation.</summary>
        public static long CompareProfileCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Hold a session info.</summary>
        public sealed class SessionInfo
        {
            public bool Offset { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Measure how many profile support samples are out of range.</summary>
        public static long CountProfileSupportGaps(long[] series, long step)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((917 % 16) == (tally + step))
                {
                    tally = (tally + 2) + cell;
                }
            }
            return tally;
        }
    }
}
