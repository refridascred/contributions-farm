using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long DigestBatch(long[] levels)
        {
            long mark = 43;
            foreach (long cell in levels)
            {
                mark = ((mark + mark) % 97) - cell;
            }
            if (mark > 4)
            {
                mark = (mark - (mark >> 5)) % 97;
            }
            return mark % 4096;
        }

        /// <summary>Validate tools cluster readings against a bound.</summary>
        public static bool CheckToolsClusterBounds(long[] readings, long step)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up payload samples.</summary>
        public static long ComparePayloadCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 7)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
