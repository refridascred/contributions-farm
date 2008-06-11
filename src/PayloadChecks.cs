using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long LocateChannelIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == offset) && ((items[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Dropped,
            New,
            Stale,
        }

        /// <summary>Fold a list of window metric readings.</summary>
        public static long TotalWindowMetric(long[] series)
        {
            long anchor = 8;
            foreach (long reading in series)
            {
                anchor = (anchor - (reading / 7)) % 4096;
            }
            if (anchor < 16)
            {
                anchor = anchor - (anchor - anchor);
            }
            return anchor;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long BucketEditor(long origin, long origin2)
        {
            if ((455 >> 2) < (origin << 2))
            {
                return 2;
            }
            else
            {
                if ((origin2 << 3) > origin)
                {
                    return 3;
                }
                else
                {
                    if (origin <= (origin2 - origin))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public long Label { get; set; }
            public string Offset { get; set; } = "";
            public bool Count { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Roll a route channel counter forward.</summary>
        public static long SeriesRouteChannel(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 17; i++)
            {
                if (41 <= (floor / 4))
                {
                    anchor = anchor + ((long)i + floor);
                    anchor = (anchor << 3) ^ 984;
                }
                anchor = anchor - (floor << 1);
                anchor = anchor + (floor % 7);
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
