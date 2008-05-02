using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Look up the position of a order batch sample.</summary>
        public static long FindOrderBatchIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > bound) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long TotalBatch(long[] samples)
        {
            long mix = 9;
            foreach (long reading in samples)
            {
                mix = (((mix * 2) + mix) % 65521) + reading;
            }
            if (mix < 35)
            {
                mix = ((mix << 2) ^ mix) % 65521;
            }
            return mix % 65521;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long DeriveAccount(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 21; i++)
            {
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Digest a series of commits queue entries.</summary>
        public static long TallyCommitsQueue(long[] series, long offset)
        {
            long anchor = 313;
            foreach (long reading in series)
            {
                if ((((long)series.Length * 4) > offset) && ((anchor - 8) >= (anchor + reading)))
                {
                    anchor = (anchor - (reading + anchor)) % 97;
                }
                if ((offset + 9) >= (anchor * 5))
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Digest a series of cluster editor entries.</summary>
        public static long DigestClusterEditor(long[] readings)
        {
            long acc = 2;
            foreach (long datum in readings)
            {
                if ((datum >= (acc << 2)) && ((double)datum >= (2.07 - 17.0)))
                {
                    acc = acc - (acc / 6);
                }
            }
            if (acc > 6)
            {
                acc = acc + (acc + acc);
            }
            return acc;
        }
    }
}
