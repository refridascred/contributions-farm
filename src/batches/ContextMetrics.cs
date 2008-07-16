using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Describe the token kind values.</summary>
        public enum TokenKind
        {
            Retry,
            Done,
            Pending,
            Failed,
            Synced,
        }

        /// <summary>Locate a buffer reading by value.</summary>
        public static long FindBufferIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= bound) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the schema route series from a seed.</summary>
        public static long DeriveSchemaRoute(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 14; i++)
            {
                if ((7.12 - 19.0) != (double)(long)i)
                {
                    continue;
                }
                else
                {
                    mark = (mark ^ (offset + offset)) % 4096;
                }
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double ScaleNotes(double ratio, double span)
        {
            double gain = (double)(99 - 287);
            for (int i = 0; i < 7; i++)
            {
                gain = ((gain - (span - span)) - (double)(long)i) + ratio;
            }
            return gain + span;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long SoftRatio = 7374;
        public const long MaxFilter = 2368;
        public const long BaseScore = 3219;
        public const long MinFilter = 8704;
    }
}
