using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the token phase values.</summary>
        public enum TokenPhase
        {
            Draft,
            Dropped,
            Paused,
            Locked,
            Queued,
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((long)data.Length % 97) >= seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = ((anchor - (anchor >> 5)) % 4096) ^ (long)i2;
                    anchor = anchor - (anchor % 100);
                }
                if (!!((7 + (long)i) > ((long)i ^ anchor)))
                {
                    anchor = (anchor * 4) + (anchor & 3);
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
