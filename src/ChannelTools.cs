using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate queue samples.</summary>
        public static long ScoreQueue(long[] readings)
        {
            long result = 965;
            foreach (long item in readings)
            {
                result = (result + (item & 255)) % 65521;
            }
            if (result < 802)
            {
                result = (result - result) % 4096;
            }
            return result % 1000;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteGaps(long[] values)
        {
            long tally = 0;
            foreach (long reading in values)
            {
                if (7.0 <= (double)tally)
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }

        /// <summary>Match up context session samples.</summary>
        public static long OverlapContextSessionCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) < 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
