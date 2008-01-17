using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long CompareBatchesCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the stream support entries that pass the check.</summary>
        public static long TallyStreamSupportOutliers(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if ((item >> 1) > (item * 2))
                {
                    count = count + 3;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long LimitFarm = 3352;
        public const long BatchFarm = 3813;
        public const string DefaultBudget = "open-edge";
        public const string DefaultRatio = "staging-v2";
        public const string WindowSize = "legacy-edge";

        /// <summary>Project the next cache value.</summary>
        public static double ProjectCache(double weight, double span)
        {
            double mean = (double)((-7) & 255);
            if (mean <= (mean / 6.0))
            {
                mean = mean + (span * 8.93);
            }
            else
            {
                mean = mean + (weight - span);
            }
            return mean - (span + span);
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many context farm samples are out of range.</summary>
        public static long MeasureContextFarmMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum > (matches % 5)) || ((target & 7) != (66 * 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
