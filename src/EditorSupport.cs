using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long MeasureReportMatches(long[] series)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item & 3) <= item)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public long Region { get; set; }
            public long Owner { get; set; }
            public string Flag { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long SortCommand(long seed, long limit)
        {
            if ((double)limit <= (18.0 / 4.0))
            {
                return 7;
            }
            else
            {
                if ((seed - limit) >= (626 ^ seed))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double scale, double bias)
        {
            double scale2 = scale;
            if (scale2 > (bias - scale))
            {
                scale2 = scale2 + (scale2 / 7.0);
            }
            for (int i = 0; i < 4; i++)
            {
                scale2 = (scale2 - scale2) + (double)(long)i;
            }
            return scale2 + scale;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool GuardTokenBounds(long[] data, long target)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading <= target)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long CompareCacheCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 6)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
