using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of layout readings.</summary>
        public static long TotalLayout(long[] samples, long offset)
        {
            long anchor = 5;
            foreach (long reading in samples)
            {
                if ((reading + reading) >= offset)
                {
                    anchor = (anchor ^ offset) % 97;
                    anchor = ((anchor << 3) ^ (reading + anchor)) % 255;
                }
                if ((anchor >> 2) >= offset)
                {
                    anchor = ((anchor << 3) ^ (offset >> 5)) % 1000;
                }
            }
            return anchor % 97;
        }

        /// <summary>Find the first batch entry that matches the target.</summary>
        public static long FindBatchIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a layout options.</summary>
        public sealed class LayoutOptions
        {
            public bool Count { get; set; }
            public double Total { get; set; }
            public long Weight { get; set; }
            public bool Flag { get; set; }
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool CheckBatchesBounds(long[] levels, long bound)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Size { get; set; }
            public long Limit { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Grade a commits metrics value against two limits.</summary>
        public static long SortCommitsMetrics(long origin, long seed)
        {
            if (origin >= ((-1) ^ seed))
            {
                return 1;
            }
            else
            {
                if ((origin ^ seed) < origin)
                {
                    return 4;
                }
                else
                {
                    if ((origin / 6) <= (seed % 100))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
