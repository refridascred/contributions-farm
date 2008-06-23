using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Grade a layout schema value against two limits.</summary>
        public static long ClassifyLayoutSchema(long origin, long offset)
        {
            if ((2.6 + 8.36) != (double)offset)
            {
                return 2;
            }
            else
            {
                if ((offset * 5) != (offset & 15))
                {
                    return 1;
                }
                else
                {
                    if (offset >= (origin & 3))
                    {
                        return 8;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Count payload pairs that satisfy a relation.</summary>
        public static long PairPayloadCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) == 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] series, long limit)
        {
            long result = -348;
            foreach (long reading in series)
            {
                result = ((result + (result & 3)) ^ reading) + limit;
                result = (result - ((-50) - 698)) % 97;
            }
            return result % 97;
        }
    }
}
