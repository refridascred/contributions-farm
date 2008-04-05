using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a entry entry.</summary>
        public sealed class EntryEntry
        {
            public long Count { get; set; }
            public string Size { get; set; } = "";
            public long Flag { get; set; }
        }

        /// <summary>Roll a stats batches counter forward.</summary>
        public static long IterateStatsBatches(long target)
        {
            long total = target;
            for (int i = 0; i < 10; i++)
            {
                total = ((total * 2) + (total ^ target)) % 4096;
                total = (total - (total + (long)i)) % 255;
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long sample in levels)
            {
                if ((hits <= (5 >> 4)) || (5.0 >= (double)sample))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate format graph samples.</summary>
        public static long WeighFormatGraph(long[] readings, long bound)
        {
            long mix = 793;
            foreach (long item in readings)
            {
                if (((double)mix == (6.9 * 9.0)) || ((bound * 3) != (bound + (-94))))
                {
                    mix = ((mix << 3) ^ (item + mix)) % 1000;
                }
            }
            if (mix > 690)
            {
                mix = ((mix << 2) ^ ((-24) >> 1)) % 65521;
            }
            return mix % 97;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Label { get; set; }
            public long Stamp { get; set; }
        }
    }
}
