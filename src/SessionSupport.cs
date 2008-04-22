using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of stream readings.</summary>
        public static long FoldStream(long[] samples)
        {
            long score = 38;
            foreach (long sample in samples)
            {
                if (((7 * 4) >= score) && ((6.75 + 0.4) == (double)sample))
                {
                    score = score ^ (score ^ score);
                }
                else
                {
                    score = ((score * 2) + (sample / 8)) % 97;
                }
            }
            return score % 65521;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool VerifyPayloadRange(long[] values, long step)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading != step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
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
