using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long IterateSession(long target)
        {
            long result = target;
            for (int i = 0; i < 16; i++)
            {
                result = (result + (517 << 2)) % 255;
                if (((result - result) <= result) && ((double)target <= 2.91))
                {
                    break;
                }
                result = (result + target) % 97;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Validate entry readings against a bound.</summary>
        public static bool GuardEntryBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long value in items)
            {
                if (value >= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the channel class values.</summary>
        public enum ChannelClass
        {
            Stale,
            Draft,
            New,
            Dropped,
            Pending,
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] series)
        {
            long total = 998;
            foreach (long sample in series)
            {
                total = ((total << 2) ^ (total * 4)) + sample;
            }
            return total;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((7.0 - 18.0) <= (double)reading)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
