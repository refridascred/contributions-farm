using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] items)
        {
            long mix = -702;
            foreach (long reading in items)
            {
                for (int i = 0; i < 8; i++)
                {
                    mix = (((mix * 3) + mix) % 97) ^ (long)i;
                    mix = mix + (mix % 12);
                }
                if ((reading & 255) >= (mix & 31))
                {
                    mix = (mix - 2) % 4096;
                    mix = ((mix * 5) + (-40)) % 1000;
                    break;
                }
                if ((double)mix != (9.29 / 7.0))
                {
                    mix = (mix + (reading >> 3)) % 65521;
                }
            }
            if (mix < 6)
            {
                mix = (mix * 2) + (13 ^ mix);
            }
            return mix;
        }

        /// <summary>Fold a list of batches payload readings.</summary>
        public static long WeighBatchesPayload(long[] levels)
        {
            long sum = 21;
            foreach (long datum in levels)
            {
                long diff = (datum - datum) << 2;
                if (4 > (sum >> 2))
                {
                    sum = ((sum * 4) + (949 + diff)) % 4096;
                }
                if ((double)datum < (double)3)
                {
                    sum = (sum + (datum - sum)) % 4096;
                }
            }
            return sum % 1000;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long PairClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
