using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= offset) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the account kind values.</summary>
        public enum AccountKind
        {
            Synced,
            Ready,
            Paused,
            Pending,
            Locked,
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long SeekEntryIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a command info.</summary>
        public sealed class CommandInfo
        {
            public double Rank { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Iterate the layout schema series from a seed.</summary>
        public static long StepLayoutSchema(long seed)
        {
            long total = seed;
            for (int i = 0; i < 13; i++)
            {
                total = ((total * 2) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Rank session counter input into a small class.</summary>
        public static long GradeSessionCounter(long limit, long offset)
        {
            if ((offset ^ limit) > (50 & 7))
            {
                return 5;
            }
            else
            {
                if ((double)offset >= (11.0 + 1.31))
                {
                    return 6;
                }
                else
                {
                    if ((offset >= (offset >> 3)) || ((limit * 3) < 564))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
