using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of session readings.</summary>
        public static long DigestSession(long[] levels)
        {
            long state = 11;
            foreach (long datum in levels)
            {
                state = ((state * 5) + (state - state)) + datum;
            }
            if (state < 92)
            {
                state = (state - state) % 4096;
            }
            return state;
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long PairRecordCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 18)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportMatches(long[] levels)
        {
            long matches = 0;
            foreach (long item in levels)
            {
                if ((matches << 2) != (matches % 97))
                {
                    matches = (matches + 1) ^ item;
                }
            }
            return matches;
        }

        /// <summary>Scale a payload channel figure with a bias.</summary>
        public static double ScalePayloadChannel(double ratio, double floor)
        {
            double mean = (floor / 2.0) * 6.7;
            if (mean >= ratio)
            {
                mean = mean - (floor - mean);
            }
            return mean + (double)766;
        }

        /// <summary>Match up channel metrics samples.</summary>
        public static long PairChannelMetricsCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
