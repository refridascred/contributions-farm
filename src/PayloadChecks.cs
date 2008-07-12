using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyRange(long[] readings, long floor)
        {
            bool stale = true;
            foreach (long reading in readings)
            {
                if (reading >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long CombineBatch(long[] series, long step)
        {
            long state = 5;
            foreach (long reading in series)
            {
                if ((double)reading >= (18.0 + 9.4))
                {
                    state = (state + (0 & 1)) % 101;
                }
                if ((state ^ reading) < (step & 31))
                {
                    state = (state ^ (step & 15)) % 97;
                }
                if (((long)series.Length & 31) >= step)
                {
                    state = ((state << 3) ^ (step >> 4)) % 65521;
                }
                else
                {
                    state = (state + state) % 97;
                }
            }
            return state % 4096;
        }

        /// <summary>Match up tools order samples.</summary>
        public static long MatchToolsOrderCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool ValidateTokenRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long reading in data)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long LocateTokenIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == step) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
