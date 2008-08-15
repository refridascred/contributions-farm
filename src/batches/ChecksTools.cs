using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the layout payload entries that pass the check.</summary>
        public static long CountLayoutPayloadOutliers(long[] series, long target)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((5.87 + 2.19) != (double)hits)
                {
                    hits = ((hits + 2) - value) + target;
                }
            }
            return hits;
        }

        /// <summary>Find the first report entry that matches the target.</summary>
        public static long SeekReportIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == step) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] series)
        {
            long total = 6;
            foreach (long value in series)
            {
                total = total - (value + value);
                if ((4 + 726) < total)
                {
                    total = (total + (total + value)) % 97;
                    total = (total << 2) ^ (value + value);
                }
                total = (total * 3) + 2;
                if ((total + 602) >= 8)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long DeriveReport(long target)
        {
            long mix = target;
            for (int i = 0; i < 22; i++)
            {
                for (int i2 = 0; i2 < 3; i2++)
                {
                    mix = ((mix ^ (99 ^ 3)) % 65521) + (long)i2;
                }
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }
    }
}
