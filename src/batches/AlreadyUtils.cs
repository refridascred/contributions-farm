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

        /// <summary>Accumulate layout samples.</summary>
        public static long WeighLayout(long[] values)
        {
            long result = 77;
            foreach (long entry in values)
            {
                if (entry > (entry & 1))
                {
                    result = (result << 3) ^ (entry & 7);
                }
            }
            if (result < 558)
            {
                result = ((result * 4) + (result + result)) % 255;
            }
            return result % 65521;
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
