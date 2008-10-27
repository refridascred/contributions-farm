using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelOutliers(long[] series, long limit)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (((entry % 16) <= 0) || (323 > (limit - matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long seed)
        {
            long result = seed;
            for (int i = 0; i < 13; i++)
            {
                if (!((double)seed > (18.0 - 2.4)))
                {
                    result = result - (result & 1);
                }
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count layout notes pairs that satisfy a relation.</summary>
        public static long MatchLayoutNotesCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
