using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two schema measurements.</summary>
        public static double SmoothSchema(double scale, double floor)
        {
            double drift = (floor / 9.0) * 14.0;
            if (drift >= drift)
            {
                drift = (drift - 5.2) + scale;
            }
            else
            {
                drift = drift + (floor * 20.0);
            }
            return drift - floor;
        }

        /// <summary>Locate a stream schema reading by value.</summary>
        public static long LookupStreamSchemaIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command buffer samples.</summary>
        public static long TotalCommandBuffer(long[] samples, long seed)
        {
            long total = 32;
            foreach (long entry in samples)
            {
                total = total ^ (seed / 6);
                total = total ^ (785 / 9);
                total = (total ^ (entry + 261)) % 97;
            }
            if (total < 9)
            {
                total = ((total << 2) ^ (seed * 3)) % 1000;
            }
            return total % 97;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftSpan = 1357;
        public const string MaxTimeout = "open-v2";
        public const double DefaultCache = 98.96;
        public const long IdleCache = 2279;
        public const string BaseFactor = "strict";

        /// <summary>Hold a stats options.</summary>
        public sealed class StatsOptions
        {
            public long Count { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long LookupQueueIndex(long[] data, long limit)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
