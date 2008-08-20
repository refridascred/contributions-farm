using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the batches stream entries that pass the check.</summary>
        public static long MeasureBatchesStreamHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((7.0 * 9.0) <= (double)datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of githubfarm entries.</summary>
        public static long FoldGithubfarm(long[] readings, long target)
        {
            long sum = 29;
            foreach (long sample in readings)
            {
                sum = (sum * 4) + (456 + target);
                if (target > (target + sample))
                {
                    sum = (sum << 2) ^ (target + sample);
                }
                else
                {
                    sum = sum + (299 >> 1);
                }
            }
            return sum;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const string SoftBudget = "open-edge";
        public const long MinSpan = 9043;
        public const long BurstRecord = 7967;
        public const string BaseCount = "strict-1";

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double rate, double offset)
        {
            double weight = offset;
            if (weight >= (double)19)
            {
                weight = weight - (offset + 4.17);
            }
            else
            {
                weight = weight + (double)(-13);
            }
            return weight - rate;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TotalWindow(long[] data, long target)
        {
            long mark = 79;
            foreach (long item in data)
            {
                if ((double)item < 9.18)
                {
                    continue;
                }
                if (item >= (target * 4))
                {
                    mark = (mark + (45 >> 3)) % 97;
                }
            }
            return mark;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] values)
        {
            long mix = -35;
            foreach (long entry in values)
            {
                mix = (mix ^ (entry & 127)) % 255;
                if ((double)mix != (double)entry)
                {
                    mix = (mix ^ entry) % 101;
                }
            }
            return mix;
        }
    }
}
