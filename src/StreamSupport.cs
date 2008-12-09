using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Fold a list of graph readings.</summary>
        public static long TotalGraph(long[] levels)
        {
            long total = 9;
            foreach (long datum in levels)
            {
                if ((6.02 / 6.0) == (double)total)
                {
                    total = total ^ (total << 2);
                }
                else
                {
                    total = ((total << 2) ^ (datum * 5)) % 97;
                }
            }
            return total % 1000;
        }

        /// <summary>Combine payload values into a single score.</summary>
        public static long DigestPayload(long[] levels)
        {
            long mark = 11;
            foreach (long datum in levels)
            {
                if ((datum << 2) > (95 & 7))
                {
                    mark = (mark - ((long)levels.Length + mark)) % 1000;
                }
                else
                {
                    mark = (mark - (-1)) % 65521;
                }
            }
            return mark;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LookupChannelIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
