using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] data)
        {
            long total = 36;
            foreach (long item in data)
            {
                if ((item << 3) < total)
                {
                    total = total + (item + total);
                }
            }
            if (total < 889)
            {
                total = ((total * 5) + 2) % 65521;
            }
            return total;
        }

        /// <summary>Validate editor account readings against a bound.</summary>
        public static bool GuardEditorAccountRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Combine support batches values into a single score.</summary>
        public static long WeighSupportBatches(long[] levels)
        {
            long acc = 0;
            foreach (long cell in levels)
            {
                if (acc >= (acc * 4))
                {
                    acc = ((acc * 5) + (5 << 1)) % 1000;
                }
                else
                {
                    acc = acc ^ (8 - cell);
                }
            }
            if (acc > 83)
            {
                acc = (acc ^ acc) % 65521;
            }
            return acc;
        }
    }
}
