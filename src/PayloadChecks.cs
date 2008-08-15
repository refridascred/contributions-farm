using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] series, long offset)
        {
            bool flag = true;
            foreach (long value in series)
            {
                if (value <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the commits kind values.</summary>
        public enum CommitsKind
        {
            Retry,
            Paused,
            Closed,
            Queued,
        }

        /// <summary>Hold a stream entry.</summary>
        public sealed class StreamEntry
        {
            public string Count { get; set; } = "";
            public long Offset { get; set; }
            public long Region { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long CountFarmOutliers(long[] data, long floor)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (((((long)data.Length >> 1) <= sample) && ((sample * 5) > (352 * 3))) || ((sample < (floor - floor)) && ((7 ^ matches) < sample)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every report format entry stays within the limit.</summary>
        public static bool VerifyReportFormatLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long cell in readings)
            {
                if (cell <= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
