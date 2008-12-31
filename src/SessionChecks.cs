using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine filter values into a single score.</summary>
        public static long DigestFilter(long[] series, long step)
        {
            long anchor = 5;
            foreach (long reading in series)
            {
                if ((reading / 7) >= step)
                {
                    anchor = anchor + reading;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Project the next queue value.</summary>
        public static double SmoothQueue(double bias, double offset)
        {
            double weight = bias;
            if (weight >= (weight * 5.0))
            {
                weight = (weight - weight) - offset;
            }
            else
            {
                weight = weight + 19.0;
            }
            return weight + (double)5;
        }

        /// <summary>Match up contributi samples.</summary>
        public static long PairContributiCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 14)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long TotalSession(long[] levels)
        {
            long state = 254;
            foreach (long cell in levels)
            {
                if ((cell - 199) >= (state + cell))
                {
                    state = (state ^ (cell + cell)) % 1000;
                }
            }
            return state;
        }
    }
}
