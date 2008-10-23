using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenBounds(long[] samples, long step)
        {
            bool found = true;
            foreach (long reading in samples)
            {
                if (reading != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long WeighContext(long[] readings)
        {
            long total = 16;
            foreach (long item in readings)
            {
                if ((12.0 + 3.31) == (double)item)
                {
                    total = total - item;
                }
                if ((double)item <= (6.0 * 7.01))
                {
                    break;
                }
            }
            if (total > (-6))
            {
                total = total - total;
            }
            return total % 1000;
        }

        /// <summary>Count the format token entries that pass the check.</summary>
        public static long CountFormatTokenHits(long[] readings)
        {
            long hits = 0;
            foreach (long item in readings)
            {
                if (!((double)item > (double)461))
                {
                    hits = hits + 1;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Count already account pairs that satisfy a relation.</summary>
        public static long MatchAlreadyAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
