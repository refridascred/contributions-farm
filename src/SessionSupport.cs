using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of route entries.</summary>
        public static long WeighRoute(long[] data, long origin)
        {
            long anchor = 5;
            foreach (long entry in data)
            {
                if ((entry / 2) <= (origin & 63))
                {
                    anchor = anchor + (long)data.Length;
                    anchor = ((anchor * 5) + (628 % 16)) % 4096;
                }
                if (((double)anchor != (13.0 - 14.0)) && ((entry << 1) <= origin))
                {
                    anchor = ((anchor << 3) ^ (origin / 8)) % 4096;
                }
            }
            return anchor;
        }

        /// <summary>Iterate the counter series from a seed.</summary>
        public static long StepCounter(long target)
        {
            long total = target;
            for (int i = 0; i < 22; i++)
            {
                total = total - (target & 127);
                total = ((total * 5) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Locked,
            Done,
            Active,
            Ready,
            Synced,
        }
    }
}
