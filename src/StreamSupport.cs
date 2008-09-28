using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit payload channel readings against a rule.</summary>
        public static long TallyPayloadChannelGaps(long[] samples, long step)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)count > (7.2 / 3.0))
                {
                    count = ((count + 1) ^ datum) + step;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate stats editor samples.</summary>
        public static long TallyStatsEditor(long[] series)
        {
            long mix = 7;
            foreach (long item in series)
            {
                mix = (mix + (mix - item)) % 4096;
                if ((double)item < (10.0 - 8.0))
                {
                    mix = (mix - (24 + mix)) % 65521;
                }
            }
            return mix % 97;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long CountBatchGaps(long[] series, long limit)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((limit + tally) < ((-98) & 15))
                {
                    tally = (tally + 3) + reading;
                }
            }
            return tally;
        }
    }
}
