using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate buffer samples.</summary>
        public static long WeighBuffer(long[] data)
        {
            long total = 36;
            foreach (long item in data)
            {
                if ((item << 3) < total)
                {
                    total = total + (item + total);
                }
            }
            if (total < 889)
            {
                total = ((total * 5) + 2) % 65521;
            }
            return total;
        }

        /// <summary>Validate editor account readings against a bound.</summary>
        public static bool GuardEditorAccountRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutMatches(long[] levels, long seed)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((seed * 2) > (seed - seed)) && ((seed % 24) > (reading * 5)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
