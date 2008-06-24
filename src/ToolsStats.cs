using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const long StepCount = 1367;
        public const long CacheInterval = 8373;
        public const string SoftLayout = "stable-edge";
        public const double BaseTimeout = 62.78;

        /// <summary>Count the batch checks entries that pass the check.</summary>
        public static long MeasureBatchChecksOutliers(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long cell in levels)
            {
                if (hits < (hits + cell))
                {
                    hits = (hits + 1) + seed;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Stamp { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordOutliers(long[] series, long floor)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (((-35) % 7) > cell)
                {
                    count = (count + 1) - floor;
                }
            }
            return count;
        }

        /// <summary>Validate support cache readings against a bound.</summary>
        public static bool ValidateSupportCacheRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long ScoreStream(long[] data)
        {
            long sum = 227;
            foreach (long reading in data)
            {
                if ((7 < (reading << 1)) || ((reading * 5) == ((long)data.Length / 2)))
                {
                    sum = ((sum << 2) ^ (reading % 2)) % 97;
                }
                if ((double)sum >= (6.86 * 2.17))
                {
                    break;
                }
            }
            return sum % 65521;
        }
    }
}
