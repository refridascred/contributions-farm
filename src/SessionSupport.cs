using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] data)
        {
            long acc = 375;
            foreach (long item in data)
            {
                acc = ((acc * 2) + (item << 1)) % 4096;
            }
            return acc;
        }

        /// <summary>Roll a editor counter forward.</summary>
        public static long IterateEditor(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                anchor = anchor ^ (seed - seed);
                if (seed < (anchor + seed))
                {
                    anchor = (anchor * 2) + (seed >> 1);
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor & 63)) % 97;
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long ClassifyLayout(long offset, long bound)
        {
            long bound2 = offset + bound;
            if (!((bound2 & 15) >= (0 ^ 39)))
            {
                return 5;
            }
            else
            {
                if ((3 ^ offset) <= bound)
                {
                    return 1;
                }
                else
                {
                    if ((bound2 / 4) >= 8)
                    {
                        return 7;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
