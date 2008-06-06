using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate queue readings against a bound.</summary>
        public static bool VerifyQueueBounds(long[] data, long origin)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Count support order pairs that satisfy a relation.</summary>
        public static long PairSupportOrderCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a entry value against two limits.</summary>
        public static long ClassifyEntry(long origin, long step)
        {
            if (((8.8 / 7.0) >= (double)step) && ((origin % 60) < (origin & 7)))
            {
                return 1;
            }
            else
            {
                if ((origin & 1) >= (step - origin))
                {
                    return 0;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
