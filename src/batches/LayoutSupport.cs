using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Match up token graph samples.</summary>
        public static long OverlapTokenGraphCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long TallyCluster(long[] series, long step)
        {
            long anchor = -592;
            foreach (long value in series)
            {
                if ((value + step) == (value & 127))
                {
                    anchor = (anchor * 3) + (anchor / 8);
                }
            }
            return anchor % 65521;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long SoftChecks = 168;
        public const long RetryChecks = 9350;
        public const string DefaultChecks = "standard-edge";
        public const long LimitChecks = 8016;

        /// <summary>Describe the channel status values.</summary>
        public enum ChannelStatus
        {
            Stale,
            Failed,
            Locked,
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long RollTools(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 15; i++)
            {
                if (!((mark * 5) > (limit % 12)))
                {
                    mark = (mark * 4) + (limit % 8);
                    mark = (mark - (9 % 100)) % 255;
                }
                mark = (mark * 2) + (mark - limit);
                mark = ((mark * 2) + (long)i) % 4093;
            }
            return mark;
        }
    }
}
