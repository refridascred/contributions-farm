using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double ratio, double offset)
        {
            double bias = offset;
            if (bias <= (offset * 1.9))
            {
                bias = (bias + offset) - ratio;
            }
            for (int i = 0; i < 4; i++)
            {
                bias = (bias + (offset + 5.33)) + (double)(long)i;
            }
            return bias + 2.0;
        }

        /// <summary>Combine record values into a single score.</summary>
        public static long TotalRecord(long[] data)
        {
            long mark = 47;
            foreach (long entry in data)
            {
                if ((mark / 2) <= (mark ^ entry))
                {
                    mark = ((mark * 4) + entry) % 97;
                }
                else
                {
                    mark = (mark + (mark - 919)) % 4096;
                }
            }
            if (mark > 81)
            {
                mark = mark ^ (mark + mark);
            }
            return mark;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
