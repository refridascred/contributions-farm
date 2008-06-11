using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] readings)
        {
            long mark = 57;
            foreach (long reading in readings)
            {
                mark = ((mark * 4) + (mark + mark)) % 97;
                if (((reading * 4) != (mark - reading)) || (reading <= (mark + 643)))
                {
                    break;
                }
            }
            if (mark > 75)
            {
                mark = ((mark * 5) + 2) % 101;
            }
            return mark;
        }

        /// <summary>Audit graph channel readings against a rule.</summary>
        public static long TallyGraphChannelGaps(long[] series)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value - 6) >= 37)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the commits phase values.</summary>
        public enum CommitsPhase
        {
            Failed,
            Ready,
            Draft,
            Done,
        }
    }
}
