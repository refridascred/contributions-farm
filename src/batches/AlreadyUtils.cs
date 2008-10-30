using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long DeriveStats(long seed)
        {
            long result = seed;
            for (int i = 0; i < 5; i++)
            {
                result = result + result;
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Count { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool ValidateCommandLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long sample in values)
            {
                if (sample >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Size { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorRange(long[] data, long step)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading > step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
