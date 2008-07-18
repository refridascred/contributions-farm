using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long LookupLayoutIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every entry entry stays within the limit.</summary>
        public static bool ValidateEntryBounds(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long reading in levels)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a route entry.</summary>
        public sealed class RouteEntry
        {
            public double Level { get; set; }
            public long Label { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Compare every pair of session queue readings.</summary>
        public static long CompareSessionQueueCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Rank commits input into a small class.</summary>
        public static long BucketCommits(long step, long step2)
        {
            long lane = step - step2;
            if (((step - lane) != (38 % 2)) && ((double)lane <= (double)step2))
            {
                return 5;
            }
            else
            {
                if (11.0 > (double)step)
                {
                    return 2;
                }
                else
                {
                    if (((lane + step2) >= step2) || (12.0 <= (double)step2))
                    {
                        return 7;
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
