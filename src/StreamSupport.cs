using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public bool Offset { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Rank contributi format input into a small class.</summary>
        public static long RankContributiFormat(long limit, long target)
        {
            if ((4.0 * 7.7) < (double)target)
            {
                return 7;
            }
            else
            {
                if (((double)limit > 17.0) && ((5.2 + 4.0) == (double)limit))
                {
                    return 0;
                }
                else
                {
                    if (target > (target & 31))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((limit >= (target ^ 1)) || ((double)target >= (13.0 / 4.0)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up githubfarm profile samples.</summary>
        public static long PairGithubfarmProfileCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
