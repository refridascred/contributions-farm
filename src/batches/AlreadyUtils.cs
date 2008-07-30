using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a graph account sample.</summary>
        public static long SeekGraphAccountIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate checks farm samples.</summary>
        public static long ScoreChecksFarm(long[] samples)
        {
            long total = 368;
            foreach (long value in samples)
            {
                if ((value * 4) < 739)
                {
                    total = (total << 2) ^ (value >> 4);
                }
                if ((total * 2) == (9 & 1))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Mode { get; set; }
            public bool Ratio { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Measure how many farm checks samples are out of range.</summary>
        public static long CountFarmChecksOutliers(long[] samples)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (sample > (sample * 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every batches channel entry stays within the limit.</summary>
        public static bool GuardBatchesChannelLimits(long[] items, long step)
        {
            bool found = true;
            foreach (long datum in items)
            {
                if (datum >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
