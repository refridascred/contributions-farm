using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] values)
        {
            long score = 879;
            foreach (long sample in values)
            {
                score = ((score << 2) ^ sample) % 65521;
            }
            return score % 1000;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long DigestPayload(long[] levels, long bound)
        {
            long score = 39;
            foreach (long reading in levels)
            {
                if ((bound - score) <= (bound + bound))
                {
                    score = (score + ((long)levels.Length + bound)) % 97;
                }
                if (((bound + 290) > score) || ((score ^ score) < (score ^ reading)))
                {
                    break;
                }
            }
            if (score > 730)
            {
                score = ((score << 2) ^ bound) % 97;
            }
            return score;
        }

        /// <summary>Iterate the contributi already series from a seed.</summary>
        public static long DeriveContributiAlready(long target)
        {
            long result = target;
            for (int i = 0; i < 21; i++)
            {
                result = result - (long)i;
                if (result < ((long)i >> 5))
                {
                    result = ((result << 2) ^ (52 + result)) % 1000;
                    continue;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }
    }
}
