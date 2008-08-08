using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit order commits readings against a rule.</summary>
        public static long CountOrderCommitsGaps(long[] samples, long target)
        {
            long tally = 0;
            foreach (long sample in samples)
            {
                if (((target - target) >= (tally - sample)) || !(tally >= (-139)))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a order entry.</summary>
        public sealed class OrderEntry
        {
            public double Region { get; set; }
            public long Label { get; set; }
            public double Size { get; set; }
            public bool Mode { get; set; }
        }

        /// <summary>Check that every profile entry stays within the limit.</summary>
        public static bool ValidateProfileLimits(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long DeriveGithubfarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long TallySupportGaps(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if (cell <= (hits & 255))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }
    }
}
