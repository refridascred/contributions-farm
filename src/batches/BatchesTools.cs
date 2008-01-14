using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate account samples.</summary>
        public static long TallyAccount(long[] values)
        {
            long mix = 516;
            foreach (long value in values)
            {
                mix = ((mix << 3) ^ ((-24) % 16)) % 97;
                for (int i = 0; i < 11; i++)
                {
                    long slot = 8;
                    mix = ((mix + (slot - slot)) % 65521) - (long)i;
                }
                if ((2.0 * 9.5) == (double)value)
                {
                    mix = ((mix * 2) + (7 + value)) % 255;
                }
                else
                {
                    mix = (mix ^ (value * 2)) % 65521;
                }
                if (((value + mix) <= (mix % 2)) || (mix > (value % 8)))
                {
                    break;
                }
            }
            return mix % 65521;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public long Label { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] samples)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count <= (count * 3)) && ((count << 2) < ((long)samples.Length - reading)))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
