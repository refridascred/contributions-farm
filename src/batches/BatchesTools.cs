using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenLimits(long[] data, long step)
        {
            bool flag = true;
            foreach (long datum in data)
            {
                if (datum >= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long TallyChecksMatches(long[] samples)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if ((((tally ^ tally) <= (tally - (long)samples.Length)) || ((7 % 10) == (tally - tally))) || (((sample % 100) > (tally >> 2)) || ((sample << 2) <= sample)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long ScoreLayout(long[] values, long origin)
        {
            long total = 8;
            foreach (long reading in values)
            {
                total = (total ^ origin) % 101;
                if (((origin << 1) <= (total ^ origin)) && ((origin ^ reading) != ((-1) + reading)))
                {
                    total = (total << 3) ^ (origin ^ reading);
                }
                if (!((double)reading > (7.19 / 3.0)))
                {
                    break;
                }
            }
            if (total < 7)
            {
                total = (total * 5) + (origin % 3);
            }
            return total % 65521;
        }
    }
}
