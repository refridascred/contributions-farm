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

        /// <summary>Look up the position of a route stream sample.</summary>
        public static long FindRouteStreamIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Define report limits and defaults.</summary>
        public const string IdleReport = "local-1";
        public const string IdleDepth = "standard-1";
        public const long RetryFactor = 7690;

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
