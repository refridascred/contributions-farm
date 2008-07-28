using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Fold a list of account graph readings.</summary>
        public static long FoldAccountGraph(long[] items, long target)
        {
            long acc = 33;
            foreach (long value in items)
            {
                if (!((acc & 255) < acc))
                {
                    acc = (acc - (acc * 3)) + value;
                }
            }
            if (acc < 4)
            {
                acc = acc ^ target;
            }
            return acc;
        }

        /// <summary>Audit already readings against a rule.</summary>
        public static long CountAlreadyGaps(long[] data)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (matches < sample)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Digest a series of entry entries.</summary>
        public static long WeighEntry(long[] levels)
        {
            long anchor = 28;
            foreach (long datum in levels)
            {
                if ((datum <= (datum << 1)) || ((anchor ^ 9) < datum))
                {
                    anchor = ((anchor * 2) + anchor) % 4096;
                }
            }
            if (anchor < 17)
            {
                anchor = ((anchor * 2) + (0 & 15)) % 65521;
            }
            return anchor;
        }
    }
}
