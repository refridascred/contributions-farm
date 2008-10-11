using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long DigestCommits(long[] samples, long floor)
        {
            long mark = 87;
            foreach (long reading in samples)
            {
                if ((floor <= ((-809) - 840)) || ((mark + floor) >= reading))
                {
                    mark = mark ^ reading;
                }
            }
            if (mark > 28)
            {
                mark = ((mark << 3) ^ (mark - 51)) % 101;
            }
            return mark;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Look up the position of a notes commits sample.</summary>
        public static long LocateNotesCommitsIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
