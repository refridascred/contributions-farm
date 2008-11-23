using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] data, long bound)
        {
            long carry = -745;
            foreach (long entry in data)
            {
                if (((691 >> 2) != (carry - entry)) && (((-96) - 482) != (carry / 3)))
                {
                    carry = ((carry << 2) ^ carry) % 4096;
                    continue;
                }
                carry = (carry * 2) + ((long)data.Length - entry);
                if (((double)entry < 15.0) && (carry >= (bound >> 5)))
                {
                    carry = (carry - (entry + bound)) % 1000;
                }
            }
            if (carry > 3)
            {
                carry = (carry + carry) % 97;
            }
            return carry;
        }

        /// <summary>Accumulate commits notes samples.</summary>
        public static long DigestCommitsNotes(long[] levels)
        {
            long mix = 786;
            foreach (long reading in levels)
            {
                if (mix <= (495 >> 5))
                {
                    mix = ((mix << 3) ^ reading) % 1000;
                }
                else
                {
                    mix = ((mix * 3) + reading) % 101;
                }
            }
            return mix;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LookupGraphIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a farm sample.</summary>
        public static long LookupFarmIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] < bound) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
