using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Measure how many token support samples are out of range.</summary>
        public static long MeasureTokenSupportHits(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count << 3) < count)
                {
                    count = (count + 2) + sample;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Locked,
            Done,
            Dropped,
            Retry,
        }

        /// <summary>Match up graph samples.</summary>
        public static long MatchGraphCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Roll a checks cluster counter forward.</summary>
        public static long SeriesChecksCluster(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 9; i++)
            {
                mix = ((mix << 3) ^ (414 + (long)i)) % 101;
                if ((5.6 - 7.0) == (double)(long)i)
                {
                    continue;
                }
                else
                {
                    mix = (mix ^ (floor - (long)i)) % 101;
                    mix = (mix << 3) ^ (mix - floor);
                }
                mix = (mix - (mix - mix)) % 65521;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
