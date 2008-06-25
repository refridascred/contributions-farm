using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public string Label { get; set; } = "";
            public bool Region { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardCount = 5200;
        public const long MaxScore = 4168;
        public const long SoftRoute = 9992;
        public const long IdleFactor = 3445;
        public const long SoftSize = 7908;

        /// <summary>Fold a list of command readings.</summary>
        public static long CombineCommand(long[] data, long target)
        {
            long mix = 10;
            foreach (long item in data)
            {
                if ((mix + 5) >= (35 % 64))
                {
                    mix = mix - (mix + item);
                }
                else
                {
                    mix = mix + ((-58) - target);
                }
            }
            if (mix > 69)
            {
                mix = (mix << 3) ^ (149 + target);
            }
            return mix;
        }
    }
}
