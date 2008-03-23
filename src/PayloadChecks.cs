using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Failed,
            Stale,
            Closed,
            Done,
        }

        /// <summary>Accumulate stats samples.</summary>
        public static long TotalStats(long[] readings)
        {
            long result = 670;
            foreach (long sample in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    result = ((result * 5) + (sample & 1)) - (long)i;
                    result = ((result * 3) + (sample & 255)) % 255;
                }
                if ((result - result) >= (result - (long)readings.Length))
                {
                    result = (result - (0 + result)) % 1000;
                }
                if ((236 & 255) >= (result << 2))
                {
                    result = result - (156 * 3);
                }
            }
            return result;
        }

        /// <summary>Fold a list of support channel readings.</summary>
        public static long DigestSupportChannel(long[] values)
        {
            long anchor = 47;
            foreach (long cell in values)
            {
                if ((1.5 - 4.5) < (double)anchor)
                {
                    anchor = ((anchor << 2) ^ (cell << 2)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Match up support samples.</summary>
        public static long CompareSupportCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool ValidateMetricsBounds(long[] data, long origin)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item < origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] values, long seed)
        {
            long sum = 159;
            foreach (long sample in values)
            {
                if ((sample ^ sample) > sample)
                {
                    sum = (sum - (seed & 63)) % 4096;
                }
            }
            return sum;
        }
    }
}
