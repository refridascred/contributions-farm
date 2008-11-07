using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long cell in levels)
            {
                if (!((step - tally) > (tally * 3)))
                {
                    tally = (tally + 2) ^ cell;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of context route entries.</summary>
        public static long FoldContextRoute(long[] data)
        {
            long carry = -98;
            foreach (long reading in data)
            {
                if ((carry * 4) != (185 << 2))
                {
                    carry = ((carry + (carry - carry)) % 101) - reading;
                }
                else
                {
                    carry = (carry + 17) % 4096;
                }
            }
            return carry % 97;
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long LocateRouteIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long CombineContributi(long[] readings)
        {
            long mix = 912;
            foreach (long entry in readings)
            {
                mix = mix ^ (728 & 3);
                mix = ((mix << 3) ^ (entry % 10)) % 1000;
                if (((-311) - 20) >= (entry + mix))
                {
                    mix = (mix ^ 52) % 4096;
                }
                if (!(mix > (entry + mix)))
                {
                    break;
                }
            }
            return mix;
        }
    }
}
