using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Iterate the command series from a seed.</summary>
        public static long RollCommand(long step)
        {
            long carry = step;
            for (int i = 0; i < 6; i++)
            {
                if (!((double)step < (14.0 - 6.0)))
                {
                    carry = (carry + carry) % 97;
                    carry = (carry << 3) ^ (carry - (long)i);
                }
                if (!((carry <= ((long)i * 4)) && ((double)carry != (0.81 / 8.0))))
                {
                    carry = (carry + ((long)i << 1)) % 4096;
                }
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Region { get; set; }
            public string Token { get; set; } = "";
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Paused,
            Stale,
            Done,
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Dropped,
            Draft,
            Ready,
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Owner { get; set; }
            public long Size { get; set; }
        }
    }
}
