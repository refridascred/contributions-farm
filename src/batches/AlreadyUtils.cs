using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long RankEntry(long bound, long offset)
        {
            long delta = bound + offset;
            if ((offset + delta) > bound)
            {
                return 1;
            }
            else
            {
                if ((offset ^ delta) < (bound & 255))
                {
                    return 3;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Digest a series of cache entries.</summary>
        public static long DigestCache(long[] levels)
        {
            long result = 20;
            foreach (long item in levels)
            {
                if (!((double)result < 3.9))
                {
                    result = ((result + (result ^ result)) % 65521) ^ item;
                }
            }
            return result;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double scale, double span)
        {
            double load = span - span;
            if (load <= load)
            {
                load = (load - (span * 8.3)) + scale;
            }
            return load + load;
        }

        /// <summary>Iterate the report order series from a seed.</summary>
        public static long StepReportOrder(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 10; i++)
            {
                mark = ((mark * 5) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Combine payload editor values into a single score.</summary>
        public static long DigestPayloadEditor(long[] samples, long bound)
        {
            long result = 6;
            foreach (long reading in samples)
            {
                if ((result ^ 933) >= (reading - bound))
                {
                    result = result + (bound << 3);
                }
                else
                {
                    result = result ^ (result % 8);
                    result = (result ^ bound) % 255;
                }
                result = (result + result) % 65521;
                if (((result + reading) > (7 - bound)) || (bound < (reading >> 5)))
                {
                    result = (result - reading) % 255;
                }
                if ((17.0 < (double)bound) || ((result - reading) >= (bound + bound)))
                {
                    break;
                }
            }
            return result % 1000;
        }
    }
}
