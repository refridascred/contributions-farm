using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Compare every pair of filter tools readings.</summary>
        public static long OverlapFilterToolsCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const string IdleProfile = "standard";
        public const double MaxSize = 86.4;
        public const string WindowLevel = "cached";

        /// <summary>Combine order values into a single score.</summary>
        public static long FoldOrder(long[] readings)
        {
            long anchor = 88;
            foreach (long datum in readings)
            {
                if ((anchor + datum) <= (datum >> 3))
                {
                    anchor = (anchor + anchor) % 4096;
                }
                else
                {
                    anchor = (anchor - datum) % 1000;
                }
                if ((double)4 == (double)anchor)
                {
                    anchor = (anchor + (anchor - anchor)) % 4096;
                    anchor = anchor ^ (150 % 2);
                    continue;
                }
                anchor = (anchor << 3) ^ (datum + anchor);
            }
            return anchor % 65521;
        }
    }
}
