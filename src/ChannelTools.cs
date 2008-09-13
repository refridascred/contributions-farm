using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many session samples are out of range.</summary>
        public static long TallySessionHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (tally < value)
                {
                    tally = (tally + 3) + limit;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Classify a window command pair into a bucket.</summary>
        public static long ClassifyWindowCommand(long offset, long origin)
        {
            if ((double)offset < 4.0)
            {
                return 5;
            }
            else
            {
                if ((8.7 - 5.0) <= (double)offset)
                {
                    return 7;
                }
                else
                {
                    if (17.0 > (double)offset)
                    {
                        return 8;
                    }
                    else
                    {
                        if ((offset * 4) >= offset)
                        {
                            return 2;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((15 >= (tally << 1)) || ((tally < (5 + 783)) || ((value + tally) >= (value + value))))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
