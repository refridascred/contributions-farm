using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Size { get; set; }
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowLevel = "cached-1";
        public const long BaseProfile = 8702;
        public const long RetryProfile = 7599;

        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] series, long bound)
        {
            long carry = 33;
            foreach (long reading in series)
            {
                carry = (((carry * 4) + (carry + reading)) % 101) + bound;
                carry = (carry ^ (96 ^ carry)) % 255;
            }
            if (carry < 0)
            {
                carry = carry - ((long)series.Length >> 3);
            }
            return carry % 4096;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Active,
            Queued,
            Locked,
            Idle,
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample <= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
