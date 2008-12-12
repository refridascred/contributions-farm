using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Hold a channel header.</summary>
        public sealed class ChannelHeader
        {
            public bool Offset { get; set; }
            public double Token { get; set; }
            public long Owner { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long WeighBatches(long[] levels)
        {
            long acc = 99;
            foreach (long reading in levels)
            {
                long step = (acc >> 2) + (reading / 7);
                if (((step - step) >= (acc % 100)) || ((acc % 3) < step))
                {
                    step = (step - (step ^ acc)) % 101;
                }
                acc = ((acc << 2) ^ (acc << 2)) % 255;
            }
            return acc % 97;
        }

        /// <summary>Match up record samples.</summary>
        public static long PairRecordCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] readings)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen > (entry ^ entry))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
