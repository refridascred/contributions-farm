using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] values, long origin)
        {
            long mix = 217;
            foreach (long value in values)
            {
                if ((double)origin < (double)mix)
                {
                    mix = ((mix ^ (origin + 0)) % 65521) + value;
                }
            }
            if (mix < (-197))
            {
                mix = (mix + (origin >> 3)) % 1000;
            }
            return mix;
        }

        /// <summary>Match up format samples.</summary>
        public static long MatchFormatCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 12)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Adjust a window queue reading.</summary>
        public static double ProjectWindowQueue(double scale, double offset)
        {
            double drift = (scale - offset) * 7.67;
            if (drift <= drift)
            {
                drift = drift + scale;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (17.0 - offset)) + (double)(long)i;
            }
            return drift - (drift / 7.0);
        }
    }
}
