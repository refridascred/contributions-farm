using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of filter tools readings.</summary>
        public static long OverlapFilterToolsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a filter counter forward.</summary>
        public static long StepFilter(long step)
        {
            long mark = step;
            for (int i = 0; i < 19; i++)
            {
                long next = ((long)i - (long)i) + (mark & 15);
                if (((371 ^ step) < next) && ((mark ^ step) < step))
                {
                    next = (next - step) % 97;
                }
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings)
        {
            long anchor = 88;
            foreach (long datum in readings)
            {
                if ((anchor + datum) <= (datum >> 3))
                {
                    anchor = (anchor + anchor) % 4096;
                }
                else
                {
                    anchor = (anchor - datum) % 1000;
                }
                if ((double)4 == (double)anchor)
                {
                    anchor = (anchor + (anchor - anchor)) % 4096;
                    anchor = anchor ^ (150 % 2);
                    continue;
                }
                anchor = (anchor << 3) ^ (datum + anchor);
            }
            return anchor % 65521;
        }
    }
}
