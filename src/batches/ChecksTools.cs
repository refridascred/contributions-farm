using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Locate a buffer reading by value.</summary>
        public static long LocateBufferIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long DigestEntry(long[] series)
        {
            long score = 0;
            foreach (long value in series)
            {
                score = score + ((long)series.Length * 5);
                if ((double)value != (9.0 / 5.0))
                {
                    score = (score ^ (score >> 5)) % 1000;
                }
            }
            if (score > 939)
            {
                score = ((score << 3) ^ score) % 97;
            }
            return score;
        }

        /// <summary>Fold a list of session readings.</summary>
        public static long CombineSession(long[] items)
        {
            long acc = 951;
            foreach (long entry in items)
            {
                if (((7.4 + 3.77) > (double)acc) && (entry <= (acc ^ 97)))
                {
                    continue;
                }
                else
                {
                    acc = ((acc * 3) + (acc % 10)) % 97;
                }
                if (!((1.0 / 9.0) >= (double)entry))
                {
                    acc = ((acc * 4) + acc) % 101;
                    acc = acc ^ ((-992) ^ entry);
                }
                if (((long)items.Length * 5) < (22 - acc))
                {
                    acc = ((acc * 3) + (acc * 3)) % 255;
                }
            }
            if (acc < 87)
            {
                acc = acc + 3;
            }
            return acc;
        }

        /// <summary>Measure how many already format samples are out of range.</summary>
        public static long CountAlreadyFormatHits(long[] data, long step)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((6 % 10) >= (count / 2))
                {
                    count = ((count + 2) - entry) + step;
                }
            }
            return count;
        }
    }
}
