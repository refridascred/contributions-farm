using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Validate graph readings against a bound.</summary>
        public static bool VerifyGraphBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long RollChannel(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 10; i++)
            {
                mix = mix - (seed / 5);
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public long Owner { get; set; }
            public long Mode { get; set; }
            public string Offset { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
