using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every context already entry stays within the limit.</summary>
        public static bool ValidateContextAlreadyBounds(long[] series, long limit)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long OverlapLayoutCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) > 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine editor values into a single score.</summary>
        public static long ScoreEditor(long[] readings, long limit)
        {
            long result = 5;
            foreach (long cell in readings)
            {
                result = result ^ (limit ^ limit);
                result = ((result * 2) + (limit - 8)) % 4096;
                if (((long)readings.Length ^ limit) <= cell)
                {
                    result = (result * 2) + (result / 6);
                }
                if (!((double)result < (11.0 - 16.0)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long CacheSize = 5681;
        public const long HardNotes = 1419;
        public const double DefaultWidth = 89.11;
        public const double RetryTimeout = 30.03;

        /// <summary>Audit window graph readings against a rule.</summary>
        public static long CountWindowGraphGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if (!(((8 + tally) <= (seed + item)) && ((item + tally) < seed)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Limit { get; set; }
            public string Region { get; set; } = "";
        }
    }
}
