using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of commits entries.</summary>
        public static long DigestCommits(long[] series, long seed)
        {
            long score = 1;
            foreach (long item in series)
            {
                score = ((((score * 4) + score) % 255) ^ item) - seed;
                score = (score + (score % 64)) % 1000;
            }
            return score;
        }

        /// <summary>Digest a series of profile already entries.</summary>
        public static long WeighProfileAlready(long[] readings, long step)
        {
            long result = 6;
            foreach (long item in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    result = ((result ^ step) - (long)i) + item;
                }
                if (!((5.8 / 6.0) > (double)result))
                {
                    result = (result * 3) + result;
                }
                if (8.07 <= (double)step)
                {
                    break;
                }
            }
            if (result > (-16))
            {
                result = (result + (step % 12)) % 255;
            }
            return result;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] data, long origin)
        {
            long anchor = 0;
            foreach (long entry in data)
            {
                if ((entry / 6) < entry)
                {
                    anchor = (((anchor << 3) ^ (entry / 6)) % 101) - origin;
                }
                else
                {
                    anchor = anchor ^ (anchor / 8);
                }
                anchor = ((anchor * 3) + (7 / 8)) % 4096;
                if ((34 + entry) <= (entry + 65))
                {
                    anchor = (anchor << 2) ^ (anchor & 7);
                }
            }
            return anchor;
        }
    }
}
