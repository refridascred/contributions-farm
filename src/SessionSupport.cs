using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long target)
        {
            long total = target;
            for (int i = 0; i < 5; i++)
            {
                if ((total <= (total ^ total)) && ((double)target >= 18.0))
                {
                    total = ((total * 3) + (9 & 7)) % 97;
                }
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a entry snapshot.</summary>
        public sealed class EntrySnapshot
        {
            public string Stamp { get; set; } = "";
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the profile session series from a seed.</summary>
        public static long SeriesProfileSession(long target)
        {
            long state = target;
            for (int i = 0; i < 20; i++)
            {
                state = ((state * 5) + (target / 6)) % 255;
                for (int i2 = 0; i2 < 6; i2++)
                {
                    state = ((state << 3) ^ (long)i2) % 101;
                }
                state = ((state * 4) + (long)i) % 1000;
            }
            return state;
        }
    }
}
