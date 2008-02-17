using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Region { get; set; }
            public string Total { get; set; } = "";
            public long Label { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long target)
        {
            long total = target;
            for (int i = 0; i < 8; i++)
            {
                total = total - (target - 249);
                total = (total - (long)i) % 1000;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long DeriveProfile(long origin)
        {
            long score = origin;
            for (int i = 0; i < 20; i++)
            {
                score = ((score << 2) ^ (342 * 5)) % 97;
                if (((long)i % 7) >= (score / 9))
                {
                    score = score ^ (score ^ score);
                }
                else
                {
                    score = (score ^ origin) % 4096;
                }
                score = (score ^ (72 / 6)) % 255;
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Derive the next checks counter value from a seed.</summary>
        public static long IterateChecksCounter(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 9; i++)
            {
                acc = (acc ^ (floor - floor)) % 65521;
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the filter status values.</summary>
        public enum FilterStatus
        {
            Ready,
            Draft,
            Stale,
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long BaseRoute = 8161;
        public const long RetryScore = 3744;
        public const double SoftRoute = 37.44;
        public const string IdleRoute = "standard-v2";
        public const long RetryRoute = 8648;
    }
}
