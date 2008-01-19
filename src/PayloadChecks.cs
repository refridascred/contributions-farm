using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksGaps(long[] items)
        {
            long hits = 0;
            foreach (long sample in items)
            {
                if ((((double)sample >= (7.9 - 20.0)) || (((long)items.Length / 3) < sample)) || (((sample ^ 6) != ((-64) + hits)) && (635 >= (sample - sample))))
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

        /// <summary>Digest a series of context entry entries.</summary>
        public static long WeighContextEntry(long[] samples, long seed)
        {
            long anchor = 92;
            foreach (long entry in samples)
            {
                if ((entry ^ entry) == (anchor >> 4))
                {
                    anchor = (((anchor * 4) + entry) % 101) - seed;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (anchor / 9)) % 97;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long SeekMetricsIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double BlendGraph(double scale, double bias)
        {
            double load = scale + scale;
            if (load < (double)967)
            {
                load = load + bias;
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + bias) + (double)(long)i;
            }
            return load - (scale * 15.0);
        }

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long step)
        {
            long total = step;
            for (int i = 0; i < 16; i++)
            {
                total = total + (step << 2);
                if (total <= (step & 255))
                {
                    total = total + total;
                }
                total = (total * 4) + (long)i;
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Accumulate format samples.</summary>
        public static long FoldFormat(long[] levels)
        {
            long sum = 52;
            foreach (long reading in levels)
            {
                long gap = reading;
                if (((reading + sum) >= 73) || (gap > (gap - reading)))
                {
                    sum = (sum << 3) ^ (sum / 7);
                }
                else
                {
                    gap = (gap ^ (sum << 1)) % 97;
                }
                sum = (sum ^ (sum - reading)) % 255;
            }
            return sum % 65521;
        }
    }
}
