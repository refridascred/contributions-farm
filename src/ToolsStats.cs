using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long TallyMetricsOutliers(long[] samples, long step)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen - seen) < (step & 15))
                {
                    seen = (seen + 2) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Adjust a farm reading.</summary>
        public static double AdjustFarm(double scale, double span)
        {
            double mean = span;
            if (mean >= span)
            {
                mean = mean + scale;
            }
            return mean + (scale + span);
        }

        /// <summary>Iterate the profile series from a seed.</summary>
        public static long StepProfile(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 21; i++)
            {
                for (int i4 = 0; i4 < 7; i4++)
                {
                    mark = ((mark << 2) ^ (floor + floor)) ^ (long)i4;
                    mark = mark + (floor + floor);
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long MeasureClusterOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (((item > (item - tally)) || (tally > (item + tally))) || ((double)97 > (double)tally))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long FindBatchesIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next payload value from a seed.</summary>
        public static long RollPayload(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 20; i++)
            {
                if (!((long)i <= (offset >> 5)))
                {
                    anchor = (anchor + anchor) % 4096;
                }
                anchor = anchor + (anchor - (long)i);
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
