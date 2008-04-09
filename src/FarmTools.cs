using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long TallyPayloadMatches(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if (((long)series.Length < 717) && ((2 > (bound + tally)) && ((double)bound > (18.0 * 12.0))))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] data, long target)
        {
            bool stale = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
