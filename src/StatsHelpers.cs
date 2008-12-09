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

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum - datum) < (53 / 4))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
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
