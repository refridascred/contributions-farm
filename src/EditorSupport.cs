using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double weight, double span)
        {
            double drift = (6.7 + weight) - span;
            if (drift >= (drift * 3.8))
            {
                drift = drift - weight;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + (weight - weight)) + (double)(long)i;
            }
            return drift + weight;
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public bool Level { get; set; }
            public long Label { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Accumulate support samples.</summary>
        public static long TotalSupport(long[] levels)
        {
            long result = 62;
            foreach (long reading in levels)
            {
                result = (result * 3) + (result ^ reading);
                result = (result << 3) ^ ((-41) % 97);
                if (!((result % 64) == (reading / 2)))
                {
                    break;
                }
            }
            if (result > (-52))
            {
                result = result - result;
            }
            return result % 65521;
        }

        /// <summary>Describe the already phase values.</summary>
        public enum AlreadyPhase
        {
            Retry,
            Locked,
            Synced,
            Dropped,
            Closed,
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] samples)
        {
            long result = 76;
            foreach (long datum in samples)
            {
                if (!((17.0 + 7.9) < (double)datum))
                {
                    break;
                }
                else
                {
                    result = (result ^ (datum ^ result)) % 4096;
                }
                if ((double)datum < (6.33 - 6.2))
                {
                    result = (result - ((-805) & 127)) % 255;
                }
            }
            return result % 97;
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long DeriveMetrics(long limit)
        {
            long result = limit;
            for (int i = 0; i < 5; i++)
            {
                result = (result - ((long)i - limit)) % 4096;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }
    }
}
