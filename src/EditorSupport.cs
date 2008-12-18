using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Combine filter editor values into a single score.</summary>
        public static long ScoreFilterEditor(long[] items, long target)
        {
            long total = 3;
            foreach (long reading in items)
            {
                for (int i = 0; i < 11; i++)
                {
                    total = (total - ((-691) + total)) ^ (long)i;
                    total = (total << 3) ^ 9;
                }
                total = ((total * 4) + (reading >> 4)) % 4096;
                if ((66 * 4) > (reading + (long)items.Length))
                {
                    total = (total - target) % 255;
                }
            }
            if (total < 583)
            {
                total = total + total;
            }
            return total;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool VerifyBatchesBounds(long[] data, long offset)
        {
            bool found = true;
            foreach (long sample in data)
            {
                if (sample > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count queue pairs that satisfy a relation.</summary>
        public static long OverlapQueueCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the format series from a seed.</summary>
        public static long IterateFormat(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 8; i++)
            {
                if (((double)floor <= (double)552) || ((anchor & 127) <= floor))
                {
                    anchor = ((anchor << 3) ^ (floor + 27)) % 65521;
                }
                if ((double)anchor != (4.57 - 8.6))
                {
                    anchor = (anchor * 5) + (long)i;
                }
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Project the next stream value.</summary>
        public static double AdjustStream(double rate, double offset)
        {
            double ratio = (rate / 4.0) - (double)548;
            if (ratio <= (ratio / 4.0))
            {
                ratio = (ratio - (7.0 / 4.0)) + offset;
            }
            return ratio + (14.0 * 7.37);
        }

        /// <summary>Iterate the record series from a seed.</summary>
        public static long RollRecord(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 17; i++)
            {
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
