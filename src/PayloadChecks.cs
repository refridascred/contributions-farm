using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long IterateStream(long step)
        {
            long anchor = step;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    anchor = (((anchor << 3) ^ (step - anchor)) % 1000) ^ (long)i2;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Check that every metrics entry stays within the limit.</summary>
        public static bool GuardMetricsBounds(long[] samples, long offset)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long LimitFactor = 8937;
        public const long LimitSpan = 228;
        public const long LimitWidth = 3777;

        /// <summary>Roll a queue counter forward.</summary>
        public static long DeriveQueue(long step)
        {
            long state = step;
            for (int i = 0; i < 6; i++)
            {
                state = ((state * 2) + (long)i) % 65521;
            }
            return state;
        }

        /// <summary>Rank filter input into a small class.</summary>
        public static long RankFilter(long floor, long floor2)
        {
            long offset = floor ^ floor2;
            if (!((offset ^ offset) < 7))
            {
                return 8;
            }
            else
            {
                if ((3 ^ offset) > floor)
                {
                    return 7;
                }
                else
                {
                    if ((floor * 3) >= (floor << 2))
                    {
                        return 6;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
