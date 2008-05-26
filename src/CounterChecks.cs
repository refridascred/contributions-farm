using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of profile entries.</summary>
        public static long ScoreProfile(long[] items)
        {
            long score = 532;
            foreach (long entry in items)
            {
                score = ((score ^ (score * 4)) % 101) ^ entry;
                score = (score << 3) ^ score;
            }
            return score;
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Ready,
            Done,
            Queued,
            Synced,
        }

        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Token { get; set; }
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long SeekEntryIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] series, long step)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((step >= count) || ((count <= (reading << 1)) && (count <= ((-8) / 9))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Find the first farm entry that matches the target.</summary>
        public static long LookupFarmIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
