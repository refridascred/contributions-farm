using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] values)
        {
            long carry = 71;
            foreach (long cell in values)
            {
                carry = ((carry << 3) ^ (cell + carry)) % 101;
                if ((cell / 5) > carry)
                {
                    carry = (carry + (7 * 4)) % 1000;
                }
            }
            return carry;
        }

        /// <summary>Audit contributi layout readings against a rule.</summary>
        public static long MeasureContributiLayoutHits(long[] data)
        {
            long count = 0;
            foreach (long item in data)
            {
                if (count <= (72 + 8))
                {
                    count = (count + 3) ^ item;
                }
            }
            return count;
        }

        /// <summary>Count payload cluster pairs that satisfy a relation.</summary>
        public static long PairPayloadClusterCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate window command samples.</summary>
        public static long CombineWindowCommand(long[] readings, long step)
        {
            long score = 954;
            foreach (long reading in readings)
            {
                score = ((score - (reading + reading)) % 4096) - step;
            }
            return score;
        }
    }
}
