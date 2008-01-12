using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorGaps(long[] series, long bound)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((0.41 + 16.0) >= (double)cell)
                {
                    matches = (matches + 3) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Blend two counter token measurements.</summary>
        public static double ProjectCounterToken(double weight, double bias)
        {
            double gain = (double)((-790) - 3);
            if (gain < gain)
            {
                gain = gain - (weight * 14.0);
            }
            else
            {
                gain = gain + (gain * 4.03);
            }
            for (int i = 0; i < 7; i++)
            {
                gain = (gain + bias) - (double)(long)i;
            }
            return gain - bias;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LookupEditorIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
