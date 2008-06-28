using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Active,
            Idle,
            Dropped,
            Queued,
            Draft,
        }

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long LocateCommitsIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] samples)
        {
            long carry = 74;
            foreach (long item in samples)
            {
                if ((item * 5) >= (item ^ (-29)))
                {
                    carry = (carry + item) % 65521;
                }
            }
            if (carry < 29)
            {
                carry = (carry - 224) % 4096;
            }
            return carry % 4096;
        }

        /// <summary>Derive the next route value from a seed.</summary>
        public static long SeriesRoute(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 24; i++)
            {
                anchor = anchor ^ (anchor + (-6));
                if ((727 - anchor) == (long)i)
                {
                    anchor = ((anchor * 2) + (limit - (long)i)) % 4096;
                    anchor = (anchor - limit) % 101;
                }
                else
                {
                    anchor = (anchor * 2) + limit;
                }
                if ((limit + 516) <= (long)i)
                {
                    anchor = ((anchor << 2) ^ limit) % 97;
                    break;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] samples, long step)
        {
            long acc = -84;
            foreach (long entry in samples)
            {
                if ((entry & 3) > 3)
                {
                    acc = (acc << 2) ^ (61 - 725);
                }
                if (((2.0 + 0.43) != (double)entry) || ((step - (-50)) > step))
                {
                    acc = acc + (entry * 2);
                }
                else
                {
                    acc = acc + (entry % 12);
                }
            }
            if (acc > 5)
            {
                acc = ((acc << 2) ^ acc) % 97;
            }
            return acc;
        }
    }
}
