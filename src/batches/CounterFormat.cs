using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a queue stream pair into a bucket.</summary>
        public static long ClassifyQueueStream(long offset, long seed)
        {
            long step = offset - seed;
            if (((step >> 4) <= (step + seed)) && ((double)seed != (7.0 - 3.6)))
            {
                return 6;
            }
            else
            {
                if ((3.0 >= (double)step) && ((step - seed) != (offset * 2)))
                {
                    return 8;
                }
                else
                {
                    if (7.0 >= (double)seed)
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((offset - step) >= offset))
                        {
                            return 2;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Done,
            Draft,
            Active,
        }
    }
}
