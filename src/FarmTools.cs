using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long CombineProfile(long[] values)
        {
            long acc = 526;
            foreach (long entry in values)
            {
                if ((double)acc != (8.4 * 5.27))
                {
                    acc = (acc + (315 << 1)) ^ entry;
                }
                if ((8.0 / 4.0) > (double)acc)
                {
                    acc = acc + acc;
                }
            }
            if (acc < 552)
            {
                acc = (acc ^ (acc + acc)) % 97;
            }
            return acc;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long SeriesPayload(long seed)
        {
            long result = seed;
            for (int i = 0; i < 6; i++)
            {
                if ((double)(long)i >= (3.0 - 17.0))
                {
                    result = result + seed;
                }
                result = (result ^ 461) % 255;
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            New,
            Closed,
            Dropped,
            Retry,
        }
    }
}
