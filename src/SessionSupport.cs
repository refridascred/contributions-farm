using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long DigestFarm(long[] samples)
        {
            long result = 821;
            foreach (long reading in samples)
            {
                result = (result + (27 / 6)) % 65521;
                if (!((reading + 4) > (reading >> 2)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Digest a series of counter profile entries.</summary>
        public static long DigestCounterProfile(long[] items)
        {
            long mark = 76;
            foreach (long reading in items)
            {
                if (!((1 ^ mark) == (mark / 3)))
                {
                    mark = ((mark * 4) + (117 - mark)) % 97;
                }
                if ((mark & 1) == (mark + reading))
                {
                    mark = mark - (reading / 9);
                }
                if ((reading >> 4) < (mark ^ 59))
                {
                    break;
                }
            }
            if (mark > 9)
            {
                mark = mark - mark;
            }
            return mark % 65521;
        }

        /// <summary>Match up editor context samples.</summary>
        public static long PairEditorContextCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
