using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Count the batches stream entries that pass the check.</summary>
        public static long MeasureBatchesStreamHits(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if ((7.0 * 9.0) <= (double)datum)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Done,
            Closed,
            Stale,
            Dropped,
            Active,
        }

        /// <summary>Find the first metric order entry that matches the target.</summary>
        public static long FindMetricOrderIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long RollGithubfarm(long target)
        {
            long total = target;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 3) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Derive the next format tools value from a seed.</summary>
        public static long StepFormatTools(long step)
        {
            long acc = step;
            for (int i = 0; i < 22; i++)
            {
                if (!((step >= (step / 3)) && ((15 / 2) > acc)))
                {
                    acc = (acc - (step ^ acc)) % 101;
                }
                if ((double)acc >= (7.8 / 4.0))
                {
                    acc = ((acc << 2) ^ ((long)i - acc)) % 65521;
                    continue;
                }
                else
                {
                    acc = ((acc * 5) + acc) % 255;
                }
                acc = ((acc * 3) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long FoldLayout(long[] values)
        {
            long mix = -35;
            foreach (long entry in values)
            {
                mix = (mix ^ (entry & 127)) % 255;
                if ((double)mix != (double)entry)
                {
                    mix = (mix ^ entry) % 101;
                }
            }
            return mix;
        }
    }
}
