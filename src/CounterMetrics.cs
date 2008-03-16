using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] items, long step)
        {
            long acc = 586;
            foreach (long reading in items)
            {
                if ((526 / 8) >= acc)
                {
                    acc = (acc + (step - acc)) - reading;
                }
            }
            if (acc > 5)
            {
                acc = ((acc << 3) ^ acc) % 101;
            }
            return acc % 4096;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Active,
            Queued,
            Ready,
        }

        /// <summary>Digest a series of profile entries.</summary>
        public static long TotalProfile(long[] samples)
        {
            long anchor = 6;
            foreach (long value in samples)
            {
                if ((double)value > (16.0 * 1.8))
                {
                    anchor = ((anchor << 2) ^ anchor) % 1000;
                    anchor = (anchor * 5) + (long)samples.Length;
                }
                if (anchor >= (anchor << 3))
                {
                    anchor = (anchor * 2) + anchor;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Match up already samples.</summary>
        public static long CompareAlreadyCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
