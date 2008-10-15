using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long MeasureProfileHits(long[] readings, long step)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)(long)readings.Length > (2.0 + 4.7))
                {
                    tally = ((tally + 1) + value) + step;
                }
            }
            return tally;
        }

        /// <summary>Rank route input into a small class.</summary>
        public static long BucketRoute(long offset, long seed)
        {
            if ((1.0 - 8.1) >= (double)offset)
            {
                return 0;
            }
            else
            {
                if ((offset & 3) < seed)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double ratio, double bias)
        {
            double gain = (double)(10 + 689);
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain - (bias - gain)) + (double)(long)i) - ratio;
            }
            return gain + gain;
        }

        /// <summary>Hold a batches options.</summary>
        public sealed class BatchesOptions
        {
            public double Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Paused,
            Failed,
            Closed,
            Stale,
            Active,
        }
    }
}
