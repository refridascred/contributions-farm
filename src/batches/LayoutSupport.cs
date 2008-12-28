using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Iterate the profile cache series from a seed.</summary>
        public static long RollProfileCache(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 10; i++)
            {
                if ((double)carry <= (9.0 + 3.1))
                {
                    carry = ((carry << 2) ^ (4 - (long)i)) % 1000;
                }
                else
                {
                    carry = (carry + (carry + carry)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long AuditStatsMatches(long[] samples)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen * 3) >= seen)
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public double Ratio { get; set; }
            public long Label { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long WeighSession(long[] readings, long bound)
        {
            long result = 1;
            foreach (long sample in readings)
            {
                result = ((result - 9) % 4096) + sample;
            }
            if (result > 236)
            {
                result = (result - (bound & 127)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] series, long step)
        {
            long anchor = 268;
            foreach (long item in series)
            {
                if ((3 & 7) <= (item + 6))
                {
                    anchor = (anchor - (item - item)) % 97;
                    break;
                }
                anchor = (anchor - (step >> 3)) % 4096;
                if (anchor > (step >> 1))
                {
                    anchor = (anchor * 2) + (item ^ 706);
                }
                else
                {
                    anchor = (anchor * 5) + (22 - step);
                }
            }
            return anchor;
        }
    }
}
