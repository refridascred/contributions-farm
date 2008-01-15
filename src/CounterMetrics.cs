using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine tools values into a single score.</summary>
        public static long FoldTools(long[] levels, long origin)
        {
            long mix = 53;
            foreach (long item in levels)
            {
                mix = (mix ^ item) % 65521;
                if (((mix << 2) >= mix) || ((origin + item) <= item))
                {
                    mix = ((mix << 3) ^ (58 ^ item)) % 65521;
                }
            }
            return mix % 65521;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long ScoreSchema(long[] readings, long step)
        {
            long acc = 59;
            foreach (long entry in readings)
            {
                acc = (acc - (entry << 3)) + step;
            }
            if (acc < 30)
            {
                acc = ((acc * 3) + (acc & 15)) % 101;
            }
            return acc;
        }

        /// <summary>Describe the farm class values.</summary>
        public enum FarmClass
        {
            Locked,
            Paused,
            Synced,
            Queued,
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long TallyWindowMatches(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (((datum >> 5) < (datum & 255)) && ((double)count > 20.0))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
