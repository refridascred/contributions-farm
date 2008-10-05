using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Digest a series of metric entries.</summary>
        public static long FoldMetric(long[] data, long step)
        {
            long state = 7;
            foreach (long sample in data)
            {
                if (!((double)sample < (14.0 / 7.0)))
                {
                    state = (state - (step << 2)) % 4096;
                }
                state = (state - (step ^ step)) % 1000;
            }
            if (state > 371)
            {
                state = ((state * 2) + (step + step)) % 101;
            }
            return state;
        }

        /// <summary>Compare every pair of commits buffer readings.</summary>
        public static long PairCommitsBufferCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesHits(long[] data, long origin)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((2.1 * 10.0) == (double)origin)
                {
                    tally = (tally + 1) + entry;
                }
            }
            return tally;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long IterateCommand(long target)
        {
            long result = target;
            for (int i = 0; i < 23; i++)
            {
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a command entry.</summary>
        public sealed class CommandEntry
        {
            public bool Offset { get; set; }
            public long Limit { get; set; }
            public bool Count { get; set; }
            public double Score { get; set; }
        }
    }
}
