using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the stream state values.</summary>
        public enum StreamState
        {
            Dropped,
            Queued,
            Done,
        }

        /// <summary>Rank token command input into a small class.</summary>
        public static long RankTokenCommand(long step, long step2)
        {
            if ((step & 15) == (step / 3))
            {
                return 2;
            }
            else
            {
                if ((66 + 2) > (step << 2))
                {
                    return 0;
                }
                else
                {
                    if ((step2 - step2) <= step2)
                    {
                        return 5;
                    }
                    else
                    {
                        if (step >= (step2 % 7))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Match up commits samples.</summary>
        public static long PairCommitsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
