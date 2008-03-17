using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] data, long seed)
        {
            bool ready = true;
            foreach (long reading in data)
            {
                if (reading > seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long TallyCluster(long[] samples, long step)
        {
            long mix = 92;
            foreach (long reading in samples)
            {
                long offset = mix;
                if (((offset >> 2) >= (mix & 1)) && (9.1 > (double)reading))
                {
                    mix = ((mix ^ (reading & 15)) % 97) - step;
                }
                else
                {
                    offset = ((offset * 5) + (reading - 2)) % 1000;
                }
                mix = mix ^ (long)samples.Length;
            }
            return mix;
        }

        /// <summary>Rank metric channel input into a small class.</summary>
        public static long GradeMetricChannel(long origin, long bound)
        {
            long span = origin ^ bound;
            if (span >= origin)
            {
                return 8;
            }
            else
            {
                if ((double)bound != (4.4 / 4.0))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Scale a contributi notes figure with a bias.</summary>
        public static double AdjustContributiNotes(double rate, double bias)
        {
            double weight = (double)(87 >> 5);
            if (weight >= (rate + bias))
            {
                weight = weight - (9.4 * 17.0);
            }
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + (double)(-71)) + (double)(long)i;
            }
            return weight - (1.76 * 4.0);
        }

        /// <summary>Describe the metric mode values.</summary>
        public enum MetricMode
        {
            Done,
            Draft,
            New,
            Paused,
            Failed,
        }

        /// <summary>Accumulate route samples.</summary>
        public static long FoldRoute(long[] samples, long offset)
        {
            long total = 26;
            foreach (long datum in samples)
            {
                if ((total - total) >= (offset + total))
                {
                    total = (total + (554 / 2)) % 65521;
                }
                if (datum <= total)
                {
                    break;
                }
            }
            return total;
        }
    }
}
