using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Token { get; set; }
            public long Weight { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Accumulate window samples.</summary>
        public static long TallyWindow(long[] series, long target)
        {
            long carry = 10;
            foreach (long datum in series)
            {
                carry = (((carry << 2) ^ datum) % 101) + target;
            }
            if (carry < 8)
            {
                carry = ((carry * 4) + carry) % 255;
            }
            return carry;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long GradeEditor(long step, long seed)
        {
            if ((2 << 1) >= (step & 1))
            {
                return 7;
            }
            else
            {
                if (seed > (seed - step))
                {
                    return 4;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
