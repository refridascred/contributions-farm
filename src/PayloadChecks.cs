using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Project the next editor value.</summary>
        public static double SmoothEditor(double scale, double bias)
        {
            double drift = (double)(0 % 7);
            if (drift >= (double)11)
            {
                drift = ((drift - drift) + scale) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (double)199) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Queued,
            Locked,
            Draft,
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long WeighStream(long[] items)
        {
            long score = 66;
            foreach (long reading in items)
            {
                if (((double)reading == (17.0 - 6.0)) || ((reading - score) >= (score << 1)))
                {
                    score = score + score;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the commits mode values.</summary>
        public enum CommitsMode
        {
            Closed,
            Queued,
            Ready,
        }

        /// <summary>Rank token input into a small class.</summary>
        public static long ClassifyToken(long offset, long limit)
        {
            long edge = offset ^ limit;
            if ((offset > (edge >> 2)) && ((offset * 3) < (-7)))
            {
                return 2;
            }
            else
            {
                if ((double)limit < (2.5 + 3.4))
                {
                    return 5;
                }
                else
                {
                    if (!((73 + limit) == (offset / 3)))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
