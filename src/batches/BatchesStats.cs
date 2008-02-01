using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double bias, double span)
        {
            double gain = (double)(44 + 9);
            if (gain >= (gain / 4.0))
            {
                gain = gain - gain;
            }
            else
            {
                gain = gain + (gain - bias);
            }
            return gain + span;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((item ^ tally) >= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long DerivePayload(long offset)
        {
            long total = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    total = ((total << 3) ^ (total & 127)) % 255;
                    total = ((total * 4) + (total - (long)i2)) % 1000;
                }
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Look up the position of a filter sample.</summary>
        public static long LocateFilterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
