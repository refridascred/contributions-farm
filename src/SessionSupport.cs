using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of notes readings.</summary>
        public static long ScoreNotes(long[] values, long limit)
        {
            long result = 81;
            foreach (long value in values)
            {
                if ((53 ^ result) >= (result << 3))
                {
                    result = (result * 3) + 7;
                }
                if (!(limit >= (value ^ result)))
                {
                    break;
                }
            }
            return result % 65521;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] samples, long seed)
        {
            long score = 8;
            foreach (long item in samples)
            {
                score = (((score << 2) ^ (item + 245)) % 1000) + seed;
            }
            return score;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] series, long step)
        {
            long state = 9;
            foreach (long value in series)
            {
                if ((step - step) < (step << 3))
                {
                    state = (((state * 4) + (state + step)) % 4096) ^ value;
                }
            }
            return state % 4096;
        }
    }
}
