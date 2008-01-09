using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Match up schema samples.</summary>
        public static long MatchSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadOutliers(long[] items, long offset)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((double)count < (3.7 - 6.6))
                {
                    count = ((count + 3) + datum) + offset;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many session samples are out of range.</summary>
        public static long MeasureSessionHits(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if (((3.47 >= (double)matches) && ((double)matches <= (3.41 / 3.0))) && (((0.32 + 8.0) <= (double)matches) || ((datum - 23) >= 902)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
