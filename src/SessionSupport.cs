using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Project the next stream value.</summary>
        public static double ProjectStream(double weight, double bias)
        {
            double scale = bias;
            if (scale >= (weight * 6.0))
            {
                scale = scale + (bias - bias);
            }
            else
            {
                scale = scale + weight;
            }
            for (int i = 0; i < 2; i++)
            {
                scale = (scale + (scale * 8.0)) + (double)(long)i;
            }
            return scale - (scale / 7.0);
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long offset, long limit)
        {
            long offset2 = offset - limit;
            if (((double)offset == (5.6 + 9.18)) && ((offset % 2) >= offset))
            {
                return 4;
            }
            else
            {
                if (((offset * 4) <= (offset + offset2)) && ((limit >> 4) < (offset2 << 2)))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit > (double)offset)
                    {
                        return 3;
                    }
                    else
                    {
                        if (((offset - offset2) < limit) && ((limit - offset2) <= offset))
                        {
                            return 8;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up window samples.</summary>
        public static long PairWindowCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
