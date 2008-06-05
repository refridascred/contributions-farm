using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if (!((double)346 >= (double)matches))
                {
                    matches = (matches + 1) + value;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long MatchAccountCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsRange(long[] series, long step)
        {
            bool valid = true;
            foreach (long datum in series)
            {
                if (datum > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
