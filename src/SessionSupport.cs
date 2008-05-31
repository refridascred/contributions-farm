using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Iterate the checks account series from a seed.</summary>
        public static long IterateChecksAccount(long step)
        {
            long mix = step;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix * 2) + (mix - mix);
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Retry,
            Closed,
            Active,
            Queued,
            Synced,
        }

        /// <summary>Fold a list of stream record readings.</summary>
        public static long TotalStreamRecord(long[] readings)
        {
            long total = 3;
            foreach (long datum in readings)
            {
                total = ((total * 5) + 11) + datum;
            }
            if (total < 426)
            {
                total = total ^ total;
            }
            return total;
        }
    }
}
