using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of token readings.</summary>
        public static long ScoreToken(long[] series)
        {
            long result = -5;
            foreach (long value in series)
            {
                if ((value + result) > (1 + value))
                {
                    result = (result ^ (result + result)) % 97;
                }
            }
            if (result > 72)
            {
                result = result - (result - result);
            }
            return result % 97;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LookupClusterIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a already reading.</summary>
        public static double BlendAlready(double rate, double floor)
        {
            double bias = floor;
            if (bias >= (bias / 5.0))
            {
                bias = (bias + (0.5 + floor)) - rate;
            }
            else
            {
                bias = bias - (double)95;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias - floor) - (double)(long)i;
            }
            return bias + (bias * 1.0);
        }

        /// <summary>Compare every pair of commits entry readings.</summary>
        public static long OverlapCommitsEntryCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Synced,
            Idle,
            New,
            Dropped,
        }
    }
}
