using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long ScoreSchema(long[] values)
        {
            long acc = 5;
            foreach (long sample in values)
            {
                acc = ((acc * 4) + (sample + sample)) % 4096;
                if ((double)(-61) == (double)acc)
                {
                    acc = (acc * 2) + (sample / 2);
                }
            }
            if (acc < 102)
            {
                acc = ((acc * 2) + (9 - acc)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Find the first token entry that matches the target.</summary>
        public static long SeekTokenIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= step) && ((items[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public bool Score { get; set; }
            public long Flag { get; set; }
        }
    }
}
