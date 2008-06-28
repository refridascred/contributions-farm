using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long TallyLayoutHits(long[] levels, long seed)
        {
            long count = 0;
            foreach (long datum in levels)
            {
                if (((count ^ 34) >= (datum % 97)) && (datum >= seed))
                {
                    count = count + 3;
                }
            }
            return count;
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

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Synced,
            Active,
            Idle,
            Pending,
            New,
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
