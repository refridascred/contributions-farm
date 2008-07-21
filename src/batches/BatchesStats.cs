using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank entry batch input into a small class.</summary>
        public static long ClassifyEntryBatch(long seed, long bound)
        {
            long next = seed - bound;
            if ((4.85 / 3.0) <= (double)bound)
            {
                return 2;
            }
            else
            {
                if ((5.2 - 7.0) <= (double)next)
                {
                    return 7;
                }
                else
                {
                    if ((2.4 / 5.0) > (double)bound)
                    {
                        return 5;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long LookupStatsIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < origin) && ((series[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a metrics counter forward.</summary>
        public static long RollMetrics(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long ScoreToken(long[] samples)
        {
            long carry = 864;
            foreach (long reading in samples)
            {
                if ((reading * 5) >= (reading >> 4))
                {
                    carry = (carry ^ (carry & 7)) % 1000;
                }
            }
            return carry % 1000;
        }
    }
}
