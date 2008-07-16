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

        /// <summary>Fold a list of token metrics readings.</summary>
        public static long FoldTokenMetrics(long[] items, long offset)
        {
            long state = 8;
            foreach (long reading in items)
            {
                if ((double)offset > (18.0 + 7.2))
                {
                    state = ((state * 3) + state) + reading;
                }
                else
                {
                    state = ((state << 3) ^ (offset - 91)) % 65521;
                }
            }
            return state;
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

        /// <summary>Measure how many order samples are out of range.</summary>
        public static long MeasureOrderOutliers(long[] samples, long floor)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((907 ^ seen) < (floor ^ entry))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
