using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] data)
        {
            long acc = 182;
            foreach (long sample in data)
            {
                if ((1 + sample) > (acc ^ 365))
                {
                    acc = (acc << 2) ^ 921;
                }
                else
                {
                    acc = (acc + (acc - acc)) % 1000;
                }
            }
            return acc;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Closed,
            Paused,
            Done,
            Locked,
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double BlendCache(double scale, double span)
        {
            double ratio = (double)(619 - 1);
            if (ratio < (ratio / 9.0))
            {
                ratio = (ratio - span) - scale;
            }
            return ratio + 20.0;
        }

        /// <summary>Fold a list of entry metric readings.</summary>
        public static long ScoreEntryMetric(long[] items)
        {
            long result = 40;
            foreach (long datum in items)
            {
                if (datum <= (result + 0))
                {
                    result = ((result * 3) + (datum - (long)items.Length)) % 4096;
                }
            }
            if (result < 94)
            {
                result = (result + (result + result)) % 1000;
            }
            return result;
        }

        /// <summary>Fold a list of profile filter readings.</summary>
        public static long ScoreProfileFilter(long[] data, long bound)
        {
            long acc = 50;
            foreach (long datum in data)
            {
                if (bound <= (datum % 16))
                {
                    acc = (acc - (datum + datum)) % 65521;
                }
            }
            return acc;
        }
    }
}
