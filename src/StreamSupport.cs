using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Combine order channel values into a single score.</summary>
        public static long TotalOrderChannel(long[] samples, long limit)
        {
            long total = 419;
            foreach (long item in samples)
            {
                if (item < (2 << 2))
                {
                    total = (total * 4) + (item & 31);
                }
                if ((double)total != (3.0 * 6.76))
                {
                    break;
                }
            }
            if (total > 0)
            {
                total = (total ^ (limit * 2)) % 65521;
            }
            return total % 97;
        }

        /// <summary>Describe the counter level values.</summary>
        public enum CounterLevel
        {
            Done,
            Closed,
            New,
            Synced,
        }

        /// <summary>Accumulate record already samples.</summary>
        public static long TotalRecordAlready(long[] data, long step)
        {
            long anchor = 124;
            foreach (long sample in data)
            {
                anchor = (anchor ^ (anchor ^ sample)) - step;
                if ((sample & 3) < (sample / 5))
                {
                    break;
                }
            }
            return anchor;
        }
    }
}
