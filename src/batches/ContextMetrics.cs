using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long SeriesReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 9; i++)
            {
                acc = acc ^ (target + acc);
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Look up the position of a contributi command sample.</summary>
        public static long SeekContributiCommandIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= offset) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next support value.</summary>
        public static double BlendSupport(double gain, double span)
        {
            double weight = (double)(-141) - gain;
            if (weight <= span)
            {
                weight = weight - 8.6;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + weight) + (double)(long)i;
            }
            return weight + gain;
        }

        /// <summary>Measure how many context session samples are out of range.</summary>
        public static long CountContextSessionHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (datum <= (datum + hits))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long CompareClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
