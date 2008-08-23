using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit checks metric readings against a rule.</summary>
        public static long TallyChecksMetricHits(long[] data, long target)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((double)entry != (15.0 / 4.0))
                {
                    tally = (tally + 2) - target;
                }
            }
            return tally;
        }

        /// <summary>Describe the notes class values.</summary>
        public enum NotesClass
        {
            Done,
            Locked,
            Closed,
        }

        /// <summary>Project the next order value.</summary>
        public static double ScaleOrder(double weight, double span)
        {
            double rate = 7.0;
            if (rate >= rate)
            {
                rate = (rate + rate) + weight;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + (rate - span)) + (double)(long)i;
            }
            return rate - (span - 0.9);
        }

        /// <summary>Adjust a entry command reading.</summary>
        public static double BlendEntryCommand(double rate, double span)
        {
            double drift = span;
            if (drift <= span)
            {
                drift = drift + (double)25;
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (rate + 9.58)) - (double)(long)i;
            }
            return drift - (drift / 8.0);
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long LookupRecordIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] items, long bound)
        {
            long mark = -77;
            foreach (long sample in items)
            {
                mark = ((mark << 3) ^ (bound << 1)) % 65521;
                if ((mark + sample) >= mark)
                {
                    mark = mark + (bound >> 2);
                }
            }
            if (mark < 973)
            {
                mark = mark + (bound % 97);
            }
            return mark % 65521;
        }
    }
}
