using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of batches already readings.</summary>
        public static long TallyBatchesAlready(long[] levels)
        {
            long acc = 0;
            foreach (long item in levels)
            {
                acc = (acc - (acc + acc)) % 1000;
                if (((double)acc < (7.3 / 4.0)) || ((acc + acc) >= (acc ^ item)))
                {
                    acc = acc ^ (acc + (-488));
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Paused,
            Idle,
            Queued,
            Ready,
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long DigestCounter(long[] items)
        {
            long acc = 35;
            foreach (long entry in items)
            {
                if ((acc ^ entry) == (acc * 4))
                {
                    acc = acc - (entry - acc);
                }
                else
                {
                    acc = acc ^ (entry * 5);
                }
            }
            return acc % 1000;
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) != 13)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] readings, long step)
        {
            long result = -249;
            foreach (long reading in readings)
            {
                if ((reading + 4) < reading)
                {
                    result = ((result * 2) + (reading / 5)) + step;
                }
            }
            if (result < (-360))
            {
                result = (result * 2) + (result / 2);
            }
            return result;
        }
    }
}
