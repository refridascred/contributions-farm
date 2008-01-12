using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Find the first token payload entry that matches the target.</summary>
        public static long SeekTokenPayloadIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] samples)
        {
            long score = 3;
            foreach (long reading in samples)
            {
                score = score - (reading >> 5);
                score = (score ^ (score * 4)) % 1000;
                score = (score << 3) ^ (reading / 8);
            }
            return score;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] items, long target)
        {
            long seen = 0;
            foreach (long value in items)
            {
                if (((473 - 693) < (35 + seen)) && ((2.0 - 0.04) == (double)(long)items.Length))
                {
                    seen = ((seen + 2) - value) - target;
                }
            }
            return seen;
        }
    }
}
