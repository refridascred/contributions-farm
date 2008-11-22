using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiHits(long[] data, long limit)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((double)hits <= 3.9)
                {
                    hits = ((hits + 3) ^ reading) + limit;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long TallyNotes(long[] samples, long bound)
        {
            long result = 8;
            foreach (long cell in samples)
            {
                if (!((bound / 8) == (bound + result)))
                {
                    result = (result + bound) % 1000;
                }
                if ((result - cell) >= bound)
                {
                    result = (result ^ (9 - result)) % 1000;
                }
                result = ((result << 2) ^ (54 << 1)) % 4096;
            }
            return result % 65521;
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandLimits(long[] samples, long floor)
        {
            bool ok = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public double Limit { get; set; }
            public long Stamp { get; set; }
            public double Size { get; set; }
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long RollBuffer(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor << 3) ^ (bound * 3)) % 97;
                if (!((anchor >> 1) <= (bound * 4)))
                {
                    anchor = (anchor - (450 & 31)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long StepAccount = 3123;
        public const double LimitAccount = 2.87;
        public const long CacheDepth = 5796;
    }
}
