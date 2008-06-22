using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Measure how many token samples are out of range.</summary>
        public static long MeasureTokenMatches(long[] values, long origin)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((origin * 2) != (213 - count))
                {
                    count = (count + 1) + entry;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                mix = (mix ^ (mix * 4)) % 4096;
                mix = ((mix * 3) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Compare every pair of profile readings.</summary>
        public static long CompareProfileCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long LocateNotesIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double bias, double offset)
        {
            double gain = (double)(60 * 3);
            if (gain >= (gain + offset))
            {
                gain = gain - (bias + 9.0);
            }
            return gain - offset;
        }
    }
}
