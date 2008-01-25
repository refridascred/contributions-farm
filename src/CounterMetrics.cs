using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long TallyEntry(long[] items, long origin)
        {
            long score = 89;
            foreach (long cell in items)
            {
                if (!((double)score >= (19.0 - 8.3)))
                {
                    score = ((score - (cell << 1)) % 1000) - origin;
                }
                else
                {
                    score = ((score << 3) ^ (score - cell)) % 1000;
                }
            }
            return score % 97;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double bias, double floor)
        {
            double ratio = (bias + 1.64) + (double)84;
            if (ratio >= (20.0 + bias))
            {
                ratio = (ratio - (ratio * 9.22)) + floor;
            }
            else
            {
                ratio = ratio + ratio;
            }
            return ratio + 7.2;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many already samples are out of range.</summary>
        public static long TallyAlreadyHits(long[] series, long target)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((matches > (matches % 100)) || (((double)matches < (double)item) && ((double)item == (double)target)))
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
