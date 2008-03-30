using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit contributi readings against a rule.</summary>
        public static long CountContributiMatches(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((-48) > (cell << 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long TallyRecord(long[] readings)
        {
            long sum = 69;
            foreach (long datum in readings)
            {
                if ((5.0 / 7.0) > (double)datum)
                {
                    sum = ((sum * 2) + ((-89) + datum)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Draft,
            Pending,
            Paused,
            Stale,
        }

        /// <summary>Digest a series of session entries.</summary>
        public static long DigestSession(long[] items)
        {
            long mix = 25;
            foreach (long item in items)
            {
                if (12.0 <= (double)mix)
                {
                    mix = mix - (mix << 2);
                }
                else
                {
                    mix = (mix * 3) + (item + item);
                }
            }
            return mix;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long WeighCluster(long[] series, long bound)
        {
            long carry = 0;
            foreach (long reading in series)
            {
                if ((carry * 4) == (reading - reading))
                {
                    carry = (carry * 4) + bound;
                }
            }
            return carry;
        }
    }
}
