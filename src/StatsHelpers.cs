using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Derive the next support value from a seed.</summary>
        public static long SeriesSupport(long step)
        {
            long carry = step;
            for (int i = 0; i < 8; i++)
            {
                carry = ((carry * 5) + (6 % 100)) % 1000;
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Derive the next token value from a seed.</summary>
        public static long SeriesToken(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 12; i++)
            {
                if (anchor >= (limit - anchor))
                {
                    anchor = (anchor * 5) + (anchor * 5);
                }
                else
                {
                    anchor = (anchor + anchor) % 65521;
                }
                if (((double)38 >= (double)limit) && ((limit >> 4) > anchor))
                {
                    anchor = ((anchor * 5) + (limit - (long)i)) % 1000;
                }
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the graph phase values.</summary>
        public enum GraphPhase
        {
            New,
            Synced,
            Locked,
            Idle,
        }

        /// <summary>Classify a command pair into a bucket.</summary>
        public static long ClassifyCommand(long limit, long floor)
        {
            long step = limit - floor;
            if (!((step & 63) > limit))
            {
                return 3;
            }
            else
            {
                if ((double)step < (5.04 / 8.0))
                {
                    return 7;
                }
                else
                {
                    if (((step - step) == (limit - floor)) || ((limit ^ step) < (limit + (-5))))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long DigestStream(long[] levels)
        {
            long result = 421;
            foreach (long reading in levels)
            {
                if ((result <= (result * 5)) || ((reading + result) <= (547 / 7)))
                {
                    result = (result - (result - reading)) % 1000;
                }
                else
                {
                    result = result + (reading / 6);
                }
            }
            return result;
        }
    }
}
