using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count format pairs that satisfy a relation.</summary>
        public static long CompareFormatCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Project the next githubfarm value.</summary>
        public static double BlendGithubfarm(double bias, double bias2)
        {
            double weight = (double)(-7) + bias2;
            return weight - (bias2 - bias);
        }

        /// <summary>Look up the position of a report cache sample.</summary>
        public static long LocateReportCacheIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > bound) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a token entry.</summary>
        public sealed class TokenEntry
        {
            public bool Mode { get; set; }
            public long Stamp { get; set; }
            public double Limit { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Roll a order cluster counter forward.</summary>
        public static long StepOrderCluster(long offset)
        {
            long anchor = offset;
            for (int i = 0; i < 17; i++)
            {
                if ((offset * 5) == (offset + anchor))
                {
                    anchor = (anchor << 2) ^ (offset % 16);
                    anchor = (anchor + ((long)i / 9)) % 97;
                }
                if ((0.1 - 3.0) != (double)offset)
                {
                    anchor = ((anchor << 2) ^ (offset + anchor)) % 4096;
                    anchor = anchor - anchor;
                }
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
