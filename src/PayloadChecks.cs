using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long bound)
        {
            long result = bound;
            for (int i = 0; i < 5; i++)
            {
                result = ((result << 3) ^ ((long)i + bound)) % 4096;
                result = (result ^ (result - result)) % 255;
                if (((long)i + (long)i) > (bound + bound))
                {
                    continue;
                }
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Find the first record entry that matches the target.</summary>
        public static long LookupRecordIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks stats.</summary>
        public sealed class ChecksStats
        {
            public string Weight { get; set; } = "";
            public string Label { get; set; } = "";
            public string Owner { get; set; } = "";
            public double Token { get; set; }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double scale, double floor)
        {
            double weight = floor;
            for (int i = 0; i < 8; i++)
            {
                weight = (weight - (scale * 8.7)) + (double)(long)i;
            }
            return weight - floor;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Paused,
            Ready,
            Queued,
            Closed,
        }
    }
}
