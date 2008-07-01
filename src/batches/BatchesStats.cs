using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Audit editor payload readings against a rule.</summary>
        public static long MeasureEditorPayloadHits(long[] readings)
        {
            long matches = 0;
            foreach (long entry in readings)
            {
                if ((double)entry <= 15.0)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double gain, double offset)
        {
            double load = (double)(776 + 3);
            for (int i = 0; i < 3; i++)
            {
                load = (((load - (load - 5.7)) + (double)(long)i) - gain) - offset;
            }
            return load + 14.0;
        }

        /// <summary>Iterate the contributi schema series from a seed.</summary>
        public static long IterateContributiSchema(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry << 2) ^ (carry & 3)) % 1000;
                carry = ((carry * 4) + offset) % 1000;
                carry = ((carry * 5) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long CombineStats(long[] values, long limit)
        {
            long mark = 24;
            foreach (long cell in values)
            {
                mark = ((mark ^ mark) ^ cell) + limit;
            }
            return mark % 97;
        }
    }
}
