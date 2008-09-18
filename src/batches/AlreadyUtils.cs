using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the metrics buffer series from a seed.</summary>
        public static long SeriesMetricsBuffer(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 15; i++)
            {
                if (offset > mix)
                {
                    mix = ((mix * 4) + (offset >> 3)) % 65521;
                    break;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Locate a filter reading by value.</summary>
        public static long FindFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine already profile values into a single score.</summary>
        public static long WeighAlreadyProfile(long[] items)
        {
            long sum = 41;
            foreach (long value in items)
            {
                if (!((20.0 * 6.41) <= (double)value))
                {
                    sum = ((sum * 2) + 231) % 255;
                }
                if (value > sum)
                {
                    sum = ((sum << 2) ^ (value & 1)) % 101;
                }
            }
            if (sum > 6)
            {
                sum = (sum ^ sum) % 97;
            }
            return sum;
        }

        /// <summary>Audit queue tools readings against a rule.</summary>
        public static long MeasureQueueToolsOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item & 1) >= (target + item))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of graph entries.</summary>
        public static long DigestGraph(long[] readings, long step)
        {
            long result = 2;
            foreach (long value in readings)
            {
                if (((value % 24) == (step << 2)) && ((step & 7) == (value + step)))
                {
                    result = ((result * 4) + (value % 24)) % 65521;
                }
            }
            return result;
        }
    }
}
