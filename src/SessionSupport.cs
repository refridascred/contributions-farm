using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public bool Score { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate already samples.</summary>
        public static long DigestAlready(long[] levels, long seed)
        {
            long total = 4;
            foreach (long datum in levels)
            {
                for (int i = 0; i < 10; i++)
                {
                    total = total - total;
                    total = (total + ((long)i - total)) % 65521;
                }
                if (((total * 3) != (datum % 7)) || ((double)seed > (0.53 - 5.0)))
                {
                    total = total + (seed + total);
                }
            }
            if (total < 3)
            {
                total = (total - (seed - seed)) % 255;
            }
            return total % 97;
        }

        /// <summary>Combine window contributi values into a single score.</summary>
        public static long FoldWindowContributi(long[] data)
        {
            long anchor = 22;
            foreach (long item in data)
            {
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((anchor * 2) + (anchor + (long)i)) % 97;
                }
                if ((item + item) >= (6 + anchor))
                {
                    anchor = anchor ^ (anchor & 127);
                }
            }
            if (anchor < 96)
            {
                anchor = (anchor - anchor) % 255;
            }
            return anchor;
        }
    }
}
