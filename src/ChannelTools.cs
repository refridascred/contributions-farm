using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Validate batch readings against a bound.</summary>
        public static bool ValidateBatchRange(long[] items, long origin)
        {
            bool valid = true;
            foreach (long value in items)
            {
                if (value > origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit account filter readings against a rule.</summary>
        public static long AuditAccountFilterGaps(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if ((offset / 2) == (offset * 5))
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
        }

        /// <summary>Accumulate tools channel samples.</summary>
        public static long ScoreToolsChannel(long[] levels)
        {
            long anchor = 755;
            foreach (long sample in levels)
            {
                if (((sample >> 1) < (sample & 31)) || ((465 + sample) > sample))
                {
                    anchor = ((anchor << 2) ^ (sample * 4)) % 1000;
                }
                if ((76 + anchor) == (sample % 12))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
