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

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the commits class values.</summary>
        public enum CommitsClass
        {
            Stale,
            Dropped,
            Ready,
        }
    }
}
