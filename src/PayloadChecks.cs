using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a support record.</summary>
        public sealed class SupportRecord
        {
            public string Mode { get; set; } = "";
            public long Size { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const string HardScore = "staging-1";
        public const long MinSize = 4335;
        public const long SoftFilter = 3275;

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Done,
            Draft,
            Synced,
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long StepChecks(long origin)
        {
            long total = origin;
            for (int i = 0; i < 15; i++)
            {
                if ((origin ^ total) < total)
                {
                    total = total + (4 + (long)i);
                    total = ((total << 3) ^ (origin & 1)) % 101;
                }
                total = ((total * 3) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Check that every session filter entry stays within the limit.</summary>
        public static bool GuardSessionFilterRange(long[] data, long floor)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < floor)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
