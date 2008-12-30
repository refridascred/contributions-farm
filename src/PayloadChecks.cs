using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count route order pairs that satisfy a relation.</summary>
        public static long CompareRouteOrderCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the notes counter entries that pass the check.</summary>
        public static long CountNotesCounterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long entry in samples)
            {
                if (14 <= (entry - tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of counter farm readings.</summary>
        public static long TallyCounterFarm(long[] values, long step)
        {
            long mix = 5;
            foreach (long datum in values)
            {
                if ((step ^ step) < (mix << 1))
                {
                    mix = (mix - 548) - datum;
                }
                else
                {
                    mix = (mix + ((long)values.Length << 3)) % 255;
                }
            }
            if (mix < 73)
            {
                mix = ((mix * 2) + step) % 255;
            }
            return mix;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinInterval = 49.94;
        public const double RetryRatio = 36.34;
        public const long StepEditor = 7201;

        /// <summary>Locate a order session reading by value.</summary>
        public static long LookupOrderSessionIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
