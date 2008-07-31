using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long ScoreBatch(long[] levels)
        {
            long state = 4;
            foreach (long datum in levels)
            {
                state = ((state << 3) ^ (84 & 3)) % 1000;
                if (((state << 1) >= state) && (datum <= (state * 3)))
                {
                    state = state - datum;
                }
                state = state + (datum >> 4);
            }
            return state;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueGaps(long[] data, long offset)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (tally >= (tally * 3))
                {
                    tally = ((tally + 1) + entry) - offset;
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
