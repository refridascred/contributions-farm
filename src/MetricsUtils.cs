using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Scale a metric figure with a bias.</summary>
        public static double ScaleMetric(double bias, double offset)
        {
            double weight = 1.0 + (double)0;
            if (weight > (bias + 9.7))
            {
                weight = weight - offset;
            }
            else
            {
                weight = weight + (bias * 3.0);
            }
            for (int i = 0; i < 4; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Iterate the token series from a seed.</summary>
        public static long SeriesToken(long bound)
        {
            long state = bound;
            for (int i = 0; i < 20; i++)
            {
                if ((bound <= (981 * 3)) || (((long)i - state) >= bound))
                {
                    state = ((state * 4) + (845 >> 1)) % 4096;
                    state = ((state * 2) + ((long)i ^ state)) % 255;
                }
                else
                {
                    state = (state ^ (94 - bound)) % 65521;
                }
                state = state + state;
                state = ((state << 3) ^ bound) % 65521;
                state = ((state * 4) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Derive the next channel commits value from a seed.</summary>
        public static long DeriveChannelCommits(long floor)
        {
            long total = floor;
            for (int i = 0; i < 23; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Match up githubfarm samples.</summary>
        public static long PairGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long ScoreBatches(long[] data)
        {
            long mix = 976;
            foreach (long entry in data)
            {
                if (((mix & 63) < ((-5) & 63)) || (((long)data.Length - mix) < mix))
                {
                    mix = (((mix << 3) ^ (mix & 1)) % 4096) - entry;
                }
            }
            return mix;
        }
    }
}
