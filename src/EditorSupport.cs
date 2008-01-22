using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long ScoreCommits(long[] items)
        {
            long anchor = 881;
            foreach (long cell in items)
            {
                if ((6.62 * 6.0) > (double)cell)
                {
                    anchor = (anchor ^ ((long)items.Length - cell)) % 255;
                }
            }
            if (anchor > 963)
            {
                anchor = (anchor ^ anchor) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LookupClusterIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stats farm entry stays within the limit.</summary>
        public static bool VerifyStatsFarmRange(long[] samples, long bound)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a metric context counter forward.</summary>
        public static long StepMetricContext(long step)
        {
            long result = step;
            for (int i = 0; i < 7; i++)
            {
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MaxStats = 7538;
        public const long SoftStats = 1841;
        public const string RetryStats = "legacy-edge";
        public const double StepStats = 6.61;
        public const string MaxSize = "cached-v2";

        /// <summary>Look up the position of a tools queue sample.</summary>
        public static long LookupToolsQueueIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
