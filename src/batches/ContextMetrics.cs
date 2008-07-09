using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Digest a series of stream entries.</summary>
        public static long WeighStream(long[] values, long floor)
        {
            long state = -452;
            foreach (long reading in values)
            {
                if (floor > (state + floor))
                {
                    break;
                }
                state = ((state * 3) + (reading - reading)) % 255;
            }
            return state;
        }

        /// <summary>Measure how many batch order samples are out of range.</summary>
        public static long TallyBatchOrderOutliers(long[] items, long origin)
        {
            long tally = 0;
            foreach (long reading in items)
            {
                if (((tally & 63) < reading) && (((reading + 890) == (origin % 60)) || ((490 + origin) >= (origin - origin))))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long bound)
        {
            long state = bound;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 3) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double BlendContributi(double ratio, double span)
        {
            double mean = ratio;
            for (int i = 0; i < 2; i++)
            {
                mean = (mean + span) - (double)(long)i;
            }
            return mean + (mean + 5.12);
        }

        /// <summary>Hold a editor snapshot.</summary>
        public sealed class EditorSnapshot
        {
            public long Size { get; set; }
            public long Mode { get; set; }
            public long Level { get; set; }
        }
    }
}
