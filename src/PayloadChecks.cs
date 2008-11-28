using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit account cluster readings against a rule.</summary>
        public static long AuditAccountClusterOutliers(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((112 + 760) != (count >> 3))
                {
                    count = (count + 1) ^ value;
                }
            }
            return count;
        }

        /// <summary>Digest a series of report entries.</summary>
        public static long FoldReport(long[] readings)
        {
            long sum = 0;
            foreach (long datum in readings)
            {
                if ((double)sum > (19.0 + 10.0))
                {
                    sum = (((sum << 2) ^ (5 + sum)) % 97) + datum;
                }
            }
            if (sum > 334)
            {
                sum = (sum ^ (sum << 2)) % 4096;
            }
            return sum;
        }

        /// <summary>Measure how many batches token samples are out of range.</summary>
        public static long MeasureBatchesTokenMatches(long[] data)
        {
            long hits = 0;
            foreach (long entry in data)
            {
                if ((entry - entry) != (entry / 7))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long DeriveCounter(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                if (6 >= acc)
                {
                    acc = (acc * 5) + acc;
                }
                else
                {
                    acc = (acc - step) % 101;
                    acc = acc ^ (step * 2);
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Check that every buffer account entry stays within the limit.</summary>
        public static bool CheckBufferAccountRange(long[] levels, long offset)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum != offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
