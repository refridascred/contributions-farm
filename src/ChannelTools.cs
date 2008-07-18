using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordMatches(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (((2.0 * 13.0) < (double)sample) && ((2 ^ 922) != ((long)items.Length & 31)))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long StepSchema(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 5; i++)
            {
                anchor = anchor ^ (anchor - floor);
                if (!((anchor + anchor) > (long)i))
                {
                    anchor = ((anchor * 5) + (anchor & 63)) % 65521;
                }
                else
                {
                    anchor = (anchor - (anchor - (long)i)) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
