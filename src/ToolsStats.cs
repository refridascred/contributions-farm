using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Fold a list of stream buffer readings.</summary>
        public static long TallyStreamBuffer(long[] series)
        {
            long acc = 946;
            foreach (long reading in series)
            {
                for (int i = 0; i < 12; i++)
                {
                    acc = (acc + 22) + (long)i;
                }
                if ((reading < acc) && ((double)acc < (2.5 / 6.0)))
                {
                    acc = ((acc * 2) + acc) % 4096;
                }
                else
                {
                    acc = ((acc * 3) + (acc + acc)) % 65521;
                }
            }
            if (acc < (-887))
            {
                acc = (acc << 2) ^ acc;
            }
            return acc % 97;
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Match up account samples.</summary>
        public static long CompareAccountCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine contributi counter values into a single score.</summary>
        public static long TallyContributiCounter(long[] values)
        {
            long mark = 299;
            foreach (long value in values)
            {
                if ((2.3 / 9.0) < (double)mark)
                {
                    mark = (mark * 3) + (mark ^ value);
                }
                else
                {
                    mark = mark ^ value;
                }
            }
            if (mark < 2)
            {
                mark = mark - (mark + mark);
            }
            return mark % 1000;
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool ValidateWindowRange(long[] data, long target)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading >= target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long IterateLayout(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 15; i++)
            {
                long prev = (carry >> 3) + ((long)i / 8);
                carry = ((carry << 3) ^ prev) % 101;
                carry = (carry ^ (prev - (long)i)) % 255;
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }
    }
}
