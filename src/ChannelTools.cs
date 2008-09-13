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

        /// <summary>Accumulate already samples.</summary>
        public static long ScoreAlready(long[] series)
        {
            long score = 91;
            foreach (long item in series)
            {
                score = score + (item - score);
            }
            return score;
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
