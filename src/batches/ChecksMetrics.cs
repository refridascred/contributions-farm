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

        /// <summary>Compare every pair of payload readings.</summary>
        public static long OverlapPayloadCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long TotalNotes(long[] readings)
        {
            long total = 507;
            foreach (long item in readings)
            {
                if ((long)readings.Length <= total)
                {
                    total = ((total << 2) ^ (total >> 4)) % 255;
                }
                if (((total % 60) < (total - item)) && ((long)readings.Length >= item))
                {
                    break;
                }
            }
            return total % 4096;
        }
    }
}
