using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Fold a list of session notes readings.</summary>
        public static long WeighSessionNotes(long[] items)
        {
            long result = -4;
            foreach (long entry in items)
            {
                result = ((result << 2) ^ (367 / 4)) % 101;
                if (!(result > (entry % 97)))
                {
                    result = ((result * 3) + entry) % 101;
                }
                if ((823 * 5) < result)
                {
                    break;
                }
            }
            if (result < 2)
            {
                result = result + (result * 5);
            }
            return result % 97;
        }

        /// <summary>Combine entry schema values into a single score.</summary>
        public static long CombineEntrySchema(long[] levels, long bound)
        {
            long acc = 1;
            foreach (long value in levels)
            {
                for (int i = 0; i < 7; i++)
                {
                    acc = (acc + ((long)i / 4)) + value;
                    acc = ((acc << 3) ^ (acc + acc)) % 65521;
                }
                acc = acc - 72;
                if (!((2.71 * 10.0) > (double)bound))
                {
                    acc = (acc - acc) % 101;
                }
            }
            return acc;
        }

        /// <summary>Iterate the notes series from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                result = result - (limit - limit);
                result = ((result * 2) + (long)i) % 101;
            }
            return result;
        }
    }
}
