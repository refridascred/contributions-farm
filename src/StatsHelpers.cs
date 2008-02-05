using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a context figure with a bias.</summary>
        public static double ScaleContext(double rate, double offset)
        {
            double load = offset / 2.0;
            for (int i = 0; i < 9; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load + rate;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long StepFilter(long step)
        {
            long acc = step;
            for (int i = 0; i < 23; i++)
            {
                if (9.4 < (double)acc)
                {
                    continue;
                }
                else
                {
                    acc = ((acc << 2) ^ ((long)i + acc)) % 255;
                }
                if (!(step > (acc - (long)i)))
                {
                    acc = acc - step;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TallySupport(long[] samples, long bound)
        {
            long acc = 2;
            foreach (long entry in samples)
            {
                acc = (acc ^ (entry ^ 99)) - bound;
            }
            return acc;
        }

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LookupRouteIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Synced,
            Retry,
            Stale,
            Dropped,
        }
    }
}
