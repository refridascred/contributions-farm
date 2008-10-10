using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a order options.</summary>
        public sealed class OrderOptions
        {
            public long Size { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long WeighAlready(long[] series, long limit)
        {
            long score = 85;
            foreach (long reading in series)
            {
                score = (score * 5) + (reading % 97);
                if ((double)limit != (13.0 * 8.77))
                {
                    break;
                }
            }
            if (score < 65)
            {
                score = ((score << 2) ^ score) % 97;
            }
            return score;
        }

        /// <summary>Iterate the metric series from a seed.</summary>
        public static long IterateMetric(long origin)
        {
            long state = origin;
            for (int i = 0; i < 4; i++)
            {
                if (((origin % 16) != (origin ^ 1)) && (state < (long)i))
                {
                    state = (state + state) % 1000;
                    state = (state ^ origin) % 97;
                }
                else
                {
                    state = (state - (91 / 3)) % 4096;
                }
                state = ((state * 5) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Project the next counter metric value.</summary>
        public static double BlendCounterMetric(double ratio, double span)
        {
            double gain = ratio;
            if (gain >= ratio)
            {
                gain = gain + span;
            }
            else
            {
                gain = gain + (double)27;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + (span - gain)) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if (((12.0 * 9.38) == (double)sample) && ((sample >> 1) < (sample - 62)))
                {
                    seen = (seen + 2) + seed;
                }
            }
            return seen;
        }
    }
}
