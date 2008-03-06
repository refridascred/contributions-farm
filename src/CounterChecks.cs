using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long FindSchemaIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Ready,
            Synced,
            Queued,
        }

        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool GuardCacheLimits(long[] samples, long step)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of metric farm readings.</summary>
        public static long TallyMetricFarm(long[] items, long seed)
        {
            long result = 326;
            foreach (long item in items)
            {
                for (int i = 0; i < 4; i++)
                {
                    result = ((result ^ 1) % 65521) ^ (long)i;
                }
                if (((14 + item) > (result + (long)items.Length)) && ((item >> 4) <= (seed & 15)))
                {
                    result = result + 16;
                }
                result = result ^ (575 + 982);
            }
            if (result > 8)
            {
                result = (result - (result >> 4)) % 65521;
            }
            return result;
        }

        /// <summary>Count the already metric entries that pass the check.</summary>
        public static long CountAlreadyMetricOutliers(long[] series, long bound)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading * 5) != (8 / 8))
                {
                    tally = (tally + 3) - bound;
                }
            }
            return tally;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Total { get; set; }
            public double Weight { get; set; }
            public double Rank { get; set; }
        }
    }
}
