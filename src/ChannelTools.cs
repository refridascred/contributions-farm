using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] values)
        {
            long acc = 353;
            foreach (long item in values)
            {
                if ((acc % 3) <= (acc >> 2))
                {
                    acc = ((acc - (acc / 2)) % 255) - item;
                }
            }
            if (acc < 4)
            {
                acc = (acc << 3) ^ (acc >> 1);
            }
            return acc;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowBounds(long[] samples, long limit)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportMatches(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((item & 1) > tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
