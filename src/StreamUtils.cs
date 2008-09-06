using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate layout filter readings against a bound.</summary>
        public static bool VerifyLayoutFilterBounds(long[] values, long origin)
        {
            bool ok = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public long Score { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] series, long bound)
        {
            long mix = 54;
            foreach (long reading in series)
            {
                if ((double)bound == (double)mix)
                {
                    mix = mix + (reading & 1);
                }
            }
            return mix;
        }

        /// <summary>Blend two support cluster measurements.</summary>
        public static double BlendSupportCluster(double rate, double bias)
        {
            double load = 2.0 + rate;
            for (int i = 0; i < 4; i++)
            {
                load = (load + (rate + bias)) - (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Classify a schema notes pair into a bucket.</summary>
        public static long GradeSchemaNotes(long seed, long limit)
        {
            if ((seed + seed) <= (limit + limit))
            {
                return 0;
            }
            else
            {
                if ((seed ^ 2) <= (seed / 8))
                {
                    return 6;
                }
                else
                {
                    if ((seed - limit) < (seed * 4))
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long MeasureSchemaHits(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((((reading ^ tally) >= (tally / 2)) && ((2.9 - 0.5) <= (double)tally)) || !(reading > (reading & 7)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
