using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Stamp { get; set; } = "";
            public long Mode { get; set; }
            public long Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long CountWindowMatches(long[] readings)
        {
            long tally = 0;
            foreach (long value in readings)
            {
                if ((double)value != (20.0 / 7.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Grade a format record value against two limits.</summary>
        public static long RankFormatRecord(long step, long target)
        {
            if (!((double)step > (9.0 / 7.0)))
            {
                return 0;
            }
            else
            {
                if ((step ^ step) != (target + step))
                {
                    return 5;
                }
                else
                {
                    if ((double)749 < (double)step)
                    {
                        return 1;
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
