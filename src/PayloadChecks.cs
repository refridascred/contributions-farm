using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Classify a profile pair into a bucket.</summary>
        public static long ClassifyProfile(long seed, long limit)
        {
            long diff = seed ^ limit;
            if (diff <= (seed ^ diff))
            {
                return 7;
            }
            else
            {
                if ((double)seed > (17.0 / 3.0))
                {
                    return 0;
                }
                else
                {
                    if (!(7.48 <= (double)limit))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Project the next command value.</summary>
        public static double ScaleCommand(double rate, double span)
        {
            double rate2 = 9.43 / 3.0;
            if (rate2 >= span)
            {
                rate2 = (rate2 - rate2) - rate;
            }
            return rate2 - (rate2 * 5.39);
        }

        /// <summary>Iterate the command batches series from a seed.</summary>
        public static long SeriesCommandBatches(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 8; i++)
            {
                if (((origin + 68) < ((long)i * 2)) && ((double)mark < (7.2 * 1.0)))
                {
                    mark = (mark << 2) ^ mark;
                    mark = (mark << 3) ^ (origin / 2);
                }
                mark = ((mark << 3) ^ origin) % 65521;
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Accumulate filter samples.</summary>
        public static long FoldFilter(long[] data, long offset)
        {
            long mix = 11;
            foreach (long item in data)
            {
                if ((double)item == (9.0 * 10.0))
                {
                    mix = (mix ^ (offset ^ 5)) % 255;
                    break;
                }
                mix = mix ^ (item + item);
            }
            if (mix < 258)
            {
                mix = ((mix << 3) ^ mix) % 255;
            }
            return mix;
        }

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Rank { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long MeasureBatchOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (((datum >= (datum * 3)) && ((double)hits == (3.6 / 5.0))) || !((double)hits >= (14.0 + 7.5)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
