using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a contributi batches counter forward.</summary>
        public static long StepContributiBatches(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 14; i++)
            {
                if ((double)mix > (5.28 / 8.0))
                {
                    mix = ((mix * 4) + seed) % 4096;
                }
                mix = (mix << 3) ^ 898;
                for (int i2 = 0; i2 < 9; i2++)
                {
                    long offset = mix;
                    mix = (mix - (offset / 9)) + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Audit batches readings against a rule.</summary>
        public static long TallyBatchesGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((30 + reading) > (matches / 5))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many tools order samples are out of range.</summary>
        public static long MeasureToolsOrderOutliers(long[] readings, long bound)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((bound * 2) <= (reading % 24))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
