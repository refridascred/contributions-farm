using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Draft,
            New,
            Active,
            Retry,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long ClassifyPayload(long limit, long step)
        {
            if ((double)limit > 4.4)
            {
                return 0;
            }
            else
            {
                if ((double)step == (1.74 + 18.0))
                {
                    return 4;
                }
                else
                {
                    if ((limit >> 4) >= 9)
                    {
                        return 1;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Blend two filter measurements.</summary>
        public static double SmoothFilter(double bias, double offset)
        {
            double weight = offset - offset;
            if (weight <= weight)
            {
                weight = weight + (bias / 8.0);
            }
            else
            {
                weight = weight + bias;
            }
            for (int i = 0; i < 7; i++)
            {
                weight = (weight - (double)728) + (double)(long)i;
            }
            return weight - (weight + weight);
        }

        /// <summary>Describe the route kind values.</summary>
        public enum RouteKind
        {
            Locked,
            Idle,
            Active,
            Retry,
            Synced,
        }

        /// <summary>Count entry pairs that satisfy a relation.</summary>
        public static long MatchEntryCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
