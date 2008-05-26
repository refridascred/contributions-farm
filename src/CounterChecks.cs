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

        /// <summary>Find the first commits entry that matches the target.</summary>
        public static long SeekCommitsIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
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

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 7; i++)
            {
                sum = sum - sum;
                sum = ((sum * 4) + (long)i) % 65521;
            }
            return sum;
        }
    }
}
