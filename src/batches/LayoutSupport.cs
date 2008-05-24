using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public long Limit { get; set; }
            public double Mode { get; set; }
            public string Count { get; set; } = "";
            public long Level { get; set; }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long LookupReportIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a cluster profile reading.</summary>
        public static double BlendClusterProfile(double scale, double floor)
        {
            double ratio = (double)14 / 9.0;
            if (ratio > scale)
            {
                ratio = ratio + 1.86;
            }
            else
            {
                ratio = ratio - floor;
            }
            for (int i = 0; i < 2; i++)
            {
                ratio = (ratio - (7.01 - scale)) - (double)(long)i;
            }
            return ratio - (double)68;
        }

        /// <summary>Derive the next already record value from a seed.</summary>
        public static long RollAlreadyRecord(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 4) + (593 << 2)) % 101;
                carry = ((carry * 4) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long MeasureTokenMatches(long[] values, long origin)
        {
            long matches = 0;
            foreach (long item in values)
            {
                if ((94 % 8) < matches)
                {
                    matches = ((matches + 2) + item) - origin;
                }
            }
            return matches;
        }
    }
}
