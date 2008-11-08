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

        /// <summary>Derive the next queue value from a seed.</summary>
        public static long DeriveQueue(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                result = (result + (bound % 2)) % 255;
                if (((long)i < result) && ((bound - 383) <= (bound ^ (long)i)))
                {
                    result = (result ^ (bound / 3)) % 1000;
                    result = ((result * 4) + (65 + result)) % 97;
                }
                else
                {
                    result = (result << 3) ^ bound;
                }
                result = ((result * 2) + (long)i) % 1000;
            }
            return result;
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

        /// <summary>Scale a report figure with a bias.</summary>
        public static double AdjustReport(double rate, double bias)
        {
            double weight = 3.0;
            for (int i = 0; i < 4; i++)
            {
                weight = ((weight - rate) + (double)(long)i) - bias;
            }
            return weight - (weight + weight);
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
