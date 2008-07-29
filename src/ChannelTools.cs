using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next metric record value from a seed.</summary>
        public static long SeriesMetricRecord(long step)
        {
            long result = step;
            for (int i = 0; i < 16; i++)
            {
                if (!(((double)result != (8.0 / 8.0)) && (result <= (result >> 5))))
                {
                    result = ((result * 3) + (step + result)) % 255;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long OverlapWindowCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the payload status values.</summary>
        public enum PayloadStatus
        {
            Stale,
            Queued,
            Draft,
            Pending,
        }
    }
}
