using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate metric record samples.</summary>
        public static long FoldMetricRecord(long[] levels, long offset)
        {
            long carry = 24;
            foreach (long reading in levels)
            {
                if ((offset + 40) >= (offset + offset))
                {
                    carry = carry + (carry << 2);
                }
                if ((5.4 + 6.9) >= (double)reading)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a batches schema sample.</summary>
        public static long SeekBatchesSchemaIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of payload counter readings.</summary>
        public static long ScorePayloadCounter(long[] readings)
        {
            long acc = 89;
            foreach (long item in readings)
            {
                acc = acc ^ (item >> 3);
            }
            return acc % 65521;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum != step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] samples, long limit)
        {
            long state = 930;
            foreach (long sample in samples)
            {
                if ((state - 322) >= (limit % 3))
                {
                    state = (state ^ (sample * 5)) % 65521;
                }
                if (sample <= (sample * 5))
                {
                    state = (state * 2) + (limit + 1);
                }
            }
            return state % 97;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long ClassifyEntry(long limit, long origin)
        {
            if (!((origin % 10) <= (limit + 2)))
            {
                return 7;
            }
            else
            {
                if ((origin >> 4) > (401 ^ 4))
                {
                    return 5;
                }
                else
                {
                    if (origin >= 8)
                    {
                        return 2;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
