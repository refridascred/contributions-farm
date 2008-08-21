using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate already samples.</summary>
        public static long CombineAlready(long[] items, long limit)
        {
            long result = 6;
            foreach (long reading in items)
            {
                if ((reading / 4) == (reading / 2))
                {
                    result = ((result * 3) + (result + result)) % 255;
                    result = ((result * 2) + (limit % 2)) % 65521;
                    break;
                }
                else
                {
                    result = (result * 5) + (reading + limit);
                    result = (result ^ (reading ^ result)) % 1000;
                }
                if ((limit ^ result) == (result - result))
                {
                    result = (result ^ result) % 4096;
                }
                else
                {
                    result = (result + (reading << 3)) % 97;
                }
            }
            return result;
        }

        /// <summary>Adjust a filter reading.</summary>
        public static double BlendFilter(double weight, double span)
        {
            double scale = weight;
            return scale - (span + 3.06);
        }

        /// <summary>Measure how many entry cluster samples are out of range.</summary>
        public static long CountEntryClusterHits(long[] series, long step)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if ((cell - count) <= (step & 3))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
