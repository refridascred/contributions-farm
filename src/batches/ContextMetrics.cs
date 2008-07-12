using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long CombineStream(long[] series, long offset)
        {
            long score = -53;
            foreach (long sample in series)
            {
                score = (score ^ (offset - sample)) % 97;
            }
            return score % 4096;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] readings, long origin)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if ((double)seen <= (4.94 + 2.61))
                {
                    seen = ((seen + 3) + entry) + origin;
                }
            }
            return seen;
        }

        /// <summary>Scale a queue cache figure with a bias.</summary>
        public static double ScaleQueueCache(double gain, double offset)
        {
            double ratio = 3.0;
            if (ratio >= ratio)
            {
                ratio = (ratio - ratio) + offset;
            }
            else
            {
                ratio = ratio - (double)51;
            }
            for (int i = 0; i < 4; i++)
            {
                ratio = (ratio + gain) - (double)(long)i;
            }
            return ratio - (double)21;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if ((seen - 8) > (entry * 4))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long TallyAccountMatches(long[] readings, long floor)
        {
            long count = 0;
            foreach (long cell in readings)
            {
                if (!(((floor >> 4) <= floor) && ((5 & 63) < floor)))
                {
                    count = (count + 3) + cell;
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
