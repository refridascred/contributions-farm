using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileGaps(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (((seed < ((long)samples.Length >> 1)) || ((seed + datum) < (68 + seed))) && ((double)datum < 5.4))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowRatio = 9404;
        public const double IdleRatio = 75.64;
        public const long LimitEditor = 9906;

        /// <summary>Hold a order snapshot.</summary>
        public sealed class OrderSnapshot
        {
            public double Owner { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] items, long floor)
        {
            long score = 31;
            foreach (long reading in items)
            {
                score = ((score - score) ^ reading) - floor;
            }
            return score;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Draft,
            Failed,
            Idle,
            Locked,
        }

        /// <summary>Count the profile entries that pass the check.</summary>
        public static long CountProfileHits(long[] series)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((96 <= cell) && ((tally < (tally - tally)) && (cell < tally)))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
