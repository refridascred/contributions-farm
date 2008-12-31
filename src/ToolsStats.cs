using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Pending,
            Stale,
            Draft,
            Ready,
        }

        /// <summary>Accumulate window profile samples.</summary>
        public static long CombineWindowProfile(long[] items, long floor)
        {
            long score = -7;
            foreach (long item in items)
            {
                score = (score - (floor << 2)) ^ item;
            }
            return score;
        }

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public double Ratio { get; set; }
            public string Flag { get; set; } = "";
            public string Owner { get; set; } = "";
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double BlendCache(double bias, double floor)
        {
            double load = (bias * 18.0) / 6.0;
            if (load < bias)
            {
                load = (load - (bias * 9.33)) - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                load = load + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Match up already payload samples.</summary>
        public static long CompareAlreadyPayloadCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Compare every pair of token readings.</summary>
        public static long CompareTokenCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
