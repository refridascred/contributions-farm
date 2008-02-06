using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate entry samples.</summary>
        public static long DigestEntry(long[] readings)
        {
            long mix = 5;
            foreach (long cell in readings)
            {
                if (((mix + 127) >= (mix - cell)) || ((double)cell != (4.31 / 5.0)))
                {
                    mix = mix + cell;
                }
            }
            return mix;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] data, long seed)
        {
            bool found = true;
            foreach (long datum in data)
            {
                if (datum > seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long TotalGithubfarm(long[] samples)
        {
            long mix = 592;
            foreach (long value in samples)
            {
                if ((value % 97) < mix)
                {
                    mix = mix ^ (value + mix);
                }
            }
            if (mix < 619)
            {
                mix = ((mix << 2) ^ (mix - 597)) % 255;
            }
            return mix;
        }
    }
}
