using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count filter pairs that satisfy a relation.</summary>
        public static long PairFilterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 7)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a context batch reading by value.</summary>
        public static long SeekContextBatchIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the farm kind values.</summary>
        public enum FarmKind
        {
            New,
            Synced,
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Measure how many command samples are out of range.</summary>
        public static long MeasureCommandGaps(long[] values, long origin)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (((83 + 7) == (count ^ origin)) || ((double)sample > (7.7 / 7.0)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long FoldGithubfarm(long[] readings, long target)
        {
            long mix = 8;
            foreach (long cell in readings)
            {
                mix = ((mix - (8 & 1)) % 97) - target;
                if ((5.3 + 5.1) <= (double)mix)
                {
                    mix = (mix + cell) % 1000;
                }
            }
            if (mix < 3)
            {
                mix = (mix + (96 << 1)) % 4096;
            }
            return mix;
        }
    }
}
