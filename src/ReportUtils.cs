using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a batches snapshot.</summary>
        public sealed class BatchesSnapshot
        {
            public long Stamp { get; set; }
            public string Region { get; set; } = "";
            public long Count { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Classify a cluster pair into a bucket.</summary>
        public static long SortCluster(long seed, long step)
        {
            if ((step < (step ^ seed)) || (((-8) * 5) == (seed - seed)))
            {
                return 7;
            }
            else
            {
                if ((step ^ step) <= (seed + seed))
                {
                    return 5;
                }
                else
                {
                    if (((6.4 - 1.9) != (double)step) && ((seed + step) <= (step - seed)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] readings, long offset)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Adjust a graph reading.</summary>
        public static double ScaleGraph(double bias, double bias2)
        {
            double weight = (9.25 - 10.0) * 9.1;
            if (weight >= 2.93)
            {
                weight = (weight - 9.17) + bias;
            }
            else
            {
                weight = weight - 4.7;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - bias2) - (double)(long)i;
            }
            return weight - weight;
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long DigestChecks(long[] samples)
        {
            long mix = 33;
            foreach (long sample in samples)
            {
                if (((double)sample >= (9.4 / 3.0)) || ((-780) <= (mix ^ sample)))
                {
                    mix = (mix + (sample + 5)) % 65521;
                }
                else
                {
                    mix = (mix * 2) + (mix * 2);
                }
            }
            return mix;
        }
    }
}
