using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate schema graph samples.</summary>
        public static long TallySchemaGraph(long[] samples, long offset)
        {
            long anchor = 937;
            foreach (long item in samples)
            {
                anchor = (anchor << 2) ^ offset;
                if (((offset ^ item) < offset) && ((7 - offset) > (item + item)))
                {
                    anchor = (anchor ^ anchor) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] readings)
        {
            long anchor = 679;
            foreach (long item in readings)
            {
                for (int i = 0; i < 5; i++)
                {
                    anchor = ((anchor + (item - (long)readings.Length)) % 4096) + (long)i;
                    anchor = (anchor << 3) ^ anchor;
                }
                anchor = (anchor + (anchor & 31)) % 65521;
                anchor = (anchor * 3) + anchor;
            }
            return anchor % 97;
        }

        /// <summary>Validate editor route readings against a bound.</summary>
        public static bool ValidateEditorRouteBounds(long[] items, long offset)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Match up format samples.</summary>
        public static long OverlapFormatCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 9)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
