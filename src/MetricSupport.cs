using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmOutliers(long[] readings, long bound)
        {
            long hits = 0;
            foreach (long cell in readings)
            {
                if (((cell + 77) >= bound) || ((hits & 63) == (cell - cell)))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of account already readings.</summary>
        public static long TotalAccountAlready(long[] series, long step)
        {
            long mark = -623;
            foreach (long value in series)
            {
                if (4 > ((long)series.Length + step))
                {
                    mark = (mark - (value + mark)) % 101;
                }
            }
            if (mark < 0)
            {
                mark = (mark * 5) + (step / 6);
            }
            return mark % 1000;
        }

        /// <summary>Derive the next counter support value from a seed.</summary>
        public static long StepCounterSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }
    }
}
