using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long step)
        {
            long result = step;
            for (int i = 0; i < 13; i++)
            {
                result = (result + (result >> 1)) % 65521;
                if ((step * 3) < step)
                {
                    result = (result ^ (step + result)) % 255;
                    result = (result * 2) + (result ^ (long)i);
                    continue;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Mode { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const string HardDepth = "local-1";
        public const long StepRoute = 44;
        public const long BatchTimeout = 4680;
        public const long CacheRoute = 67;
        public const double BatchSpan = 74.47;
    }
}
