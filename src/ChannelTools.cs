using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Look up the position of a support command sample.</summary>
        public static long FindSupportCommandIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long DigestBatch(long[] series, long bound)
        {
            long acc = 61;
            foreach (long reading in series)
            {
                if ((acc ^ bound) != (acc + reading))
                {
                    acc = acc + ((-41) + reading);
                }
                acc = (acc << 2) ^ (acc << 1);
            }
            if (acc > 2)
            {
                acc = acc ^ (acc + acc);
            }
            return acc;
        }

        /// <summary>Grade a token value against two limits.</summary>
        public static long ClassifyToken(long step, long step2)
        {
            long step3 = step + step2;
            if (!((step2 + step2) >= step))
            {
                return 2;
            }
            else
            {
                if ((step >= step2) || ((step3 << 3) <= (step2 + step)))
                {
                    return 8;
                }
                else
                {
                    if ((step3 & 127) > 56)
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((5.11 / 3.0) > (double)step2))
                        {
                            return 6;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
