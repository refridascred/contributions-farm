using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double HardDepth = 32.23;
        public const long SoftLayout = 9794;
        public const double RetryLevel = 45.15;
        public const double LimitLayout = 23.36;

        /// <summary>Roll a filter support counter forward.</summary>
        public static long DeriveFilterSupport(long target)
        {
            long mix = target;
            for (int i = 0; i < 9; i++)
            {
                if (!((mix / 3) == (mix + target)))
                {
                    mix = ((mix * 2) + (mix * 5)) % 1000;
                }
                if (((double)target != (13.0 - 4.12)) && ((double)target != (5.9 + 3.8)))
                {
                    mix = (mix - (target ^ mix)) % 97;
                    mix = ((mix << 3) ^ (-3)) % 255;
                }
                else
                {
                    mix = (mix + 2) % 255;
                }
                mix = ((mix * 4) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public long Owner { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }
    }
}
