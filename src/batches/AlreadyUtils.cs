using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first command notes entry that matches the target.</summary>
        public static long LocateCommandNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public double Stamp { get; set; }
            public double Level { get; set; }
            public long Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Hold a farm options.</summary>
        public sealed class FarmOptions
        {
            public bool Label { get; set; }
            public long Offset { get; set; }
            public bool Token { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public bool Level { get; set; }
            public double Region { get; set; }
            public string Flag { get; set; } = "";
            public bool Size { get; set; }
        }

        /// <summary>Grade a profile editor value against two limits.</summary>
        public static long GradeProfileEditor(long seed, long step)
        {
            long diff = seed - step;
            if ((diff % 24) == (167 - seed))
            {
                return 7;
            }
            else
            {
                if (((step & 15) >= (step << 1)) && ((double)diff != (0.22 + 17.0)))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }
    }
}
