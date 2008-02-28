using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Synced,
            Done,
            Failed,
            Locked,
            Stale,
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((double)offset == (5.0 / 4.0))
                {
                    sum = sum - ((-50) >> 4);
                }
                if (((double)offset != (3.01 + 9.13)) && ((16.0 + 5.43) >= (double)offset))
                {
                    sum = sum + (5 + (long)i);
                }
                else
                {
                    sum = (sum * 4) + (5 + (long)i);
                }
                sum = (sum - ((long)i / 7)) % 255;
                sum = ((sum * 2) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long SeekOrderIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= origin) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the report layout entries that pass the check.</summary>
        public static long CountReportLayoutHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if ((value - 544) <= 61)
                {
                    seen = (seen + 3) - step;
                }
            }
            return seen;
        }
    }
}
