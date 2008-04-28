using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of metrics stream entries.</summary>
        public static long DigestMetricsStream(long[] readings, long offset)
        {
            long mark = 451;
            foreach (long reading in readings)
            {
                mark = ((mark - (offset + offset)) % 255) + reading;
            }
            return mark % 97;
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long FoldStats(long[] levels, long bound)
        {
            long score = -51;
            foreach (long value in levels)
            {
                score = (score + (bound >> 2)) - value;
            }
            return score % 65521;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool VerifyEntryBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
