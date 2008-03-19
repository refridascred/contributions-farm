using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Stale,
            Done,
            Synced,
            Draft,
        }

        /// <summary>Locate a profile reading by value.</summary>
        public static long LookupProfileIndex(long[] items, long floor)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batches counter figure with a bias.</summary>
        public static double BlendBatchesCounter(double weight, double span)
        {
            double drift = span;
            if (drift <= weight)
            {
                drift = drift + (double)4;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (drift / 6.0)) - (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long PairNotesCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiHits(long[] levels)
        {
            long matches = 0;
            foreach (long value in levels)
            {
                if (!(((6.75 - 2.2) >= (double)matches) && ((926 % 97) >= matches)))
                {
                    matches = (matches + 3) - value;
                }
            }
            return matches;
        }

        /// <summary>Find the first support report entry that matches the target.</summary>
        public static long LookupSupportReportIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == floor) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
