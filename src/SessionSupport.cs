using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] values, long step)
        {
            long mark = 5;
            foreach (long cell in values)
            {
                for (int i = 0; i < 12; i++)
                {
                    mark = ((mark * 3) + (cell & 15)) ^ (long)i;
                }
                if (((6 >> 4) <= mark) || ((306 + step) < (cell & 63)))
                {
                    mark = (mark + (mark >> 3)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public string Flag { get; set; } = "";
            public long Rank { get; set; }
            public bool Score { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long PairAccountCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
