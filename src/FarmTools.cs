using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Idle,
            Failed,
            Queued,
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] items, long bound)
        {
            long total = 117;
            foreach (long reading in items)
            {
                if ((reading >= (bound - reading)) && ((long)items.Length >= (reading + (long)items.Length)))
                {
                    total = total - (110 ^ (-549));
                }
                total = ((total << 2) ^ reading) % 97;
                if ((260 < (total + total)) && ((801 + total) < (reading / 2)))
                {
                    break;
                }
            }
            return total % 65521;
        }

        /// <summary>Count token pairs that satisfy a relation.</summary>
        public static long OverlapTokenCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
