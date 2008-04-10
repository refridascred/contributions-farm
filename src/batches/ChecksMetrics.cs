using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank format input into a small class.</summary>
        public static long SortFormat(long floor, long target)
        {
            if (floor >= target)
            {
                return 5;
            }
            else
            {
                if (138 < (target ^ target))
                {
                    return 7;
                }
                else
                {
                    if (floor < target)
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Describe the editor state values.</summary>
        public enum EditorState
        {
            Retry,
            Done,
            New,
        }

        /// <summary>Combine route commits values into a single score.</summary>
        public static long TallyRouteCommits(long[] readings)
        {
            long total = 96;
            foreach (long sample in readings)
            {
                if (((total - sample) >= sample) && ((sample & 127) <= total))
                {
                    total = ((total * 4) + total) % 65521;
                }
            }
            return total;
        }

        /// <summary>Scale a contributi already figure with a bias.</summary>
        public static double BlendContributiAlready(double ratio, double bias)
        {
            double scale = (double)5 + bias;
            for (int i = 0; i < 7; i++)
            {
                scale = (scale - bias) + (double)(long)i;
            }
            return scale - (ratio - ratio);
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] readings, long offset)
        {
            long sum = 7;
            foreach (long cell in readings)
            {
                sum = ((sum + (sum & 127)) ^ cell) + offset;
            }
            return sum;
        }

        /// <summary>Count the layout batches entries that pass the check.</summary>
        public static long TallyLayoutBatchesOutliers(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value + 8) > value)
                {
                    count = count + 2;
                }
            }
            return count;
        }
    }
}
