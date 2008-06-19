using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] items)
        {
            long acc = 2;
            foreach (long entry in items)
            {
                acc = (acc ^ (entry % 2)) % 255;
                if ((7.76 / 4.0) < (double)acc)
                {
                    acc = ((acc * 3) + (entry >> 3)) % 97;
                }
            }
            return acc % 97;
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long DigestContext(long[] series)
        {
            long state = -976;
            foreach (long entry in series)
            {
                if ((state & 3) >= state)
                {
                    state = ((state << 2) ^ (state + state)) ^ entry;
                }
            }
            return state % 4096;
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long WeighBatch(long[] readings, long bound)
        {
            long score = 2;
            foreach (long cell in readings)
            {
                score = ((score + (cell + score)) % 65521) + bound;
            }
            if (score < (-131))
            {
                score = (score ^ (score + score)) % 65521;
            }
            return score % 97;
        }
    }
}
