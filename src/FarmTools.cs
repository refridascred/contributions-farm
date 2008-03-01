using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long MaxPayload = 892;
        public const double SoftPayload = 48.36;
        public const long WindowCount = 3828;
        public const long BurstSpan = 5693;

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 23; i++)
            {
                if (!((seed + seed) != (mix + seed)))
                {
                    mix = ((mix * 2) + seed) % 97;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a notes record.</summary>
        public sealed class NotesRecord
        {
            public double Limit { get; set; }
            public string Size { get; set; } = "";
            public bool Score { get; set; }
            public long Region { get; set; }
        }
    }
}
