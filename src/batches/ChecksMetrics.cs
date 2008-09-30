using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double SmoothPayload(double scale, double bias)
        {
            double weight = scale;
            if (weight < bias)
            {
                weight = weight + (weight * 3.5);
            }
            return weight + (bias * 8.8);
        }

        /// <summary>Roll a command githubfarm counter forward.</summary>
        public static long DeriveCommandGithubfarm(long offset)
        {
            long result = offset;
            for (int i = 0; i < 8; i++)
            {
                if (!((double)offset >= (15.0 * 4.96)))
                {
                    result = ((result * 3) + (result >> 4)) % 4096;
                    result = result + (8 + offset);
                }
                result = (result * 3) + (offset + result);
                result = result - (long)i;
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Flag { get; set; }
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Match up buffer samples.</summary>
        public static long CompareBufferCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 2)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Define already limits and defaults.</summary>
        public const long WindowAlready = 9186;
        public const long DefaultScore = 9918;
        public const double CacheAlready = 81.4;
    }
}
