using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Audit channel layout readings against a rule.</summary>
        public static long AuditChannelLayoutMatches(long[] data, long target)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if (!((entry << 1) != (count << 2)))
                {
                    count = (count + 1) + target;
                }
            }
            return count;
        }

        /// <summary>Describe the order class values.</summary>
        public enum OrderClass
        {
            Dropped,
            Stale,
            Draft,
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                if ((mark / 8) > (step ^ mark))
                {
                    mark = mark + (long)i;
                }
                else
                {
                    mark = (mark << 2) ^ step;
                    mark = (mark ^ mark) % 101;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool ValidateQueueBounds(long[] readings, long step)
        {
            bool ready = true;
            foreach (long datum in readings)
            {
                if (datum < step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings)
        {
            long carry = 328;
            foreach (long reading in readings)
            {
                carry = (carry ^ (reading * 4)) % 4096;
            }
            if (carry > 4)
            {
                carry = (carry << 3) ^ (carry - carry);
            }
            return carry;
        }
    }
}
