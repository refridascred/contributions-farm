using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long IterateChannel(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 15; i++)
            {
                anchor = (anchor + seed) % 101;
                anchor = ((anchor * 2) + anchor) % 65521;
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorGaps(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (!((double)hits >= (0.7 - 9.04)))
                {
                    hits = (hits + 2) ^ value;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of token context entries.</summary>
        public static long WeighTokenContext(long[] data, long floor)
        {
            long acc = -86;
            foreach (long item in data)
            {
                if (77 >= (acc * 4))
                {
                    acc = (acc + (floor * 3)) - item;
                }
            }
            if (acc > 692)
            {
                acc = (acc - acc) % 97;
            }
            return acc;
        }

        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double gain, double bias)
        {
            double weight = 0.7 / 7.0;
            for (int i = 0; i < 5; i++)
            {
                weight = (weight + gain) - (double)(long)i;
            }
            return weight + (bias * 4.4);
        }

        /// <summary>Validate format batches readings against a bound.</summary>
        public static bool ValidateFormatBatchesBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long value in data)
            {
                if (value <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
