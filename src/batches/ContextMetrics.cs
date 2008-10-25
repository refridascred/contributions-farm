using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] data, long bound)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= bound) && ((data[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MinOrder = 3859;
        public const string IdleOrder = "staging-1";
        public const long HardWidth = 6626;
        public const long BaseOrder = 3610;
        public const long MaxInterval = 1890;

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long OverlapSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of notes readings.</summary>
        public static long FoldNotes(long[] items)
        {
            long acc = -34;
            foreach (long entry in items)
            {
                if (!(2.93 > (double)(long)items.Length))
                {
                    acc = (acc - ((-131) ^ acc)) + entry;
                }
                else
                {
                    acc = ((acc << 2) ^ ((-43) % 24)) % 101;
                }
            }
            if (acc > 803)
            {
                acc = ((acc << 2) ^ (acc / 8)) % 1000;
            }
            return acc;
        }
    }
}
