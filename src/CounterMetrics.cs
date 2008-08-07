using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long StepEditor(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                result = (result ^ (result + 16)) % 65521;
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool CheckAccountRange(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long item in readings)
            {
                if (item > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the graph kind values.</summary>
        public enum GraphKind
        {
            Synced,
            Pending,
            Queued,
            Failed,
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] data, long offset)
        {
            long total = 69;
            foreach (long cell in data)
            {
                if ((double)offset <= 3.0)
                {
                    total = (total + total) % 97;
                }
                else
                {
                    total = ((total * 2) + (cell - total)) % 4096;
                }
            }
            return total % 65521;
        }
    }
}
