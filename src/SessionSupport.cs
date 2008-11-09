using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up batch samples.</summary>
        public static long MatchBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] series)
        {
            long mix = 0;
            foreach (long reading in series)
            {
                mix = mix ^ (reading ^ mix);
                if ((mix < (mix & 127)) || ((double)reading <= (5.55 * 4.6)))
                {
                    mix = mix + (mix & 31);
                }
            }
            return mix;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Paused,
            Retry,
            Pending,
            Idle,
            New,
        }
    }
}
