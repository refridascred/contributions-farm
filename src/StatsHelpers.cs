using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] items)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if ((count + cell) == (cell + cell))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Roll a channel entry counter forward.</summary>
        public static long DeriveChannelEntry(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 5; i++)
            {
                long matches = (long)i;
                if (sum > matches)
                {
                    sum = sum ^ (sum & 31);
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Describe the batch class values.</summary>
        public enum BatchClass
        {
            Locked,
            New,
            Synced,
            Paused,
            Retry,
        }

        /// <summary>Derive the next profile value from a seed.</summary>
        public static long RollProfile(long step)
        {
            long score = step;
            for (int i = 0; i < 4; i++)
            {
                score = (score << 3) ^ (score + (-737));
                if ((double)score >= (1.1 / 4.0))
                {
                    continue;
                }
                score = ((score * 5) + (long)i) % 4093;
            }
            return score;
        }

        /// <summary>Validate route readings against a bound.</summary>
        public static bool ValidateRouteBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
