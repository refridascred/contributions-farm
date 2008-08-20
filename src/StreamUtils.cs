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

        /// <summary>Adjust a profile reading.</summary>
        public static double SmoothProfile(double bias, double offset)
        {
            double load = offset * 20.0;
            if (load >= (13.0 / 6.0))
            {
                load = (load - load) - bias;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + (2.4 * 4.3)) - (double)(long)i;
            }
            return load + (load * 8.98);
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Flag { get; set; } = "";
            public long Label { get; set; }
            public long Limit { get; set; }
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

        /// <summary>Classify a editor buffer pair into a bucket.</summary>
        public static long SortEditorBuffer(long offset, long step)
        {
            if (((offset >> 4) <= (step & 1)) || ((3.0 + 7.0) < (double)step))
            {
                return 5;
            }
            else
            {
                if (((step ^ 124) > step) && (step < (offset << 3)))
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
