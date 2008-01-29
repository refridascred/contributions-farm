using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Match up metric samples.</summary>
        public static long PairMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Pending,
            Dropped,
            Done,
            Stale,
            Synced,
        }

        /// <summary>Scale a commits payload figure with a bias.</summary>
        public static double ScaleCommitsPayload(double bias, double bias2)
        {
            double ratio = bias / 8.0;
            if (ratio < bias2)
            {
                ratio = ratio + bias2;
            }
            else
            {
                ratio = ratio + bias;
            }
            return ratio - 4.0;
        }
    }
}
