using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Find the first schema entry that matches the target.</summary>
        public static long SeekSchemaIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the queue class values.</summary>
        public enum QueueClass
        {
            Ready,
            New,
            Idle,
        }

        /// <summary>Scale a notes figure with a bias.</summary>
        public static double BlendNotes(double bias, double offset)
        {
            double weight = (double)36 * 5.0;
            for (int i = 0; i < 9; i++)
            {
                weight = ((weight + 18.0) + (double)(long)i) + offset;
            }
            return weight + (bias * 1.1);
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double rate, double span)
        {
            double gain = rate / 5.0;
            return (gain - (rate * 5.0)) + span;
        }

        /// <summary>Compare every pair of graph readings.</summary>
        public static long PairGraphCount(long[] items)
        {
            long hits = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) != 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
