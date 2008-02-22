using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((cell / 7) > (count ^ 21)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Count the support entries that pass the check.</summary>
        public static long TallySupportMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (count <= datum)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate context token readings against a bound.</summary>
        public static bool ValidateContextTokenBounds(long[] series, long seed)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value < seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public double Flag { get; set; }
        }
    }
}
