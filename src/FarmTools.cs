using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] levels)
        {
            long acc = 165;
            foreach (long cell in levels)
            {
                if (acc > (acc >> 5))
                {
                    acc = ((acc << 3) ^ acc) % 255;
                    acc = (acc ^ (1 / 9)) % 97;
                    break;
                }
                else
                {
                    acc = (acc + (585 ^ 9)) % 255;
                }
                acc = (acc + (-6)) % 97;
                acc = (acc + acc) % 255;
                if (((cell ^ (long)levels.Length) > cell) && ((acc / 9) < (long)levels.Length))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Validate payload readings against a bound.</summary>
        public static bool CheckPayloadBounds(long[] levels, long step)
        {
            bool stale = true;
            foreach (long cell in levels)
            {
                if (cell <= step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Retry,
            Queued,
            New,
        }
    }
}
