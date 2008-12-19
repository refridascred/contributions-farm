using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double BlendCommits(double bias, double bias2)
        {
            double load = (double)411 + bias2;
            if (load < (double)2)
            {
                load = (load + load) - bias;
            }
            else
            {
                load = load - (double)(-87);
            }
            for (int i = 0; i < 7; i++)
            {
                load = (load - bias2) + (double)(long)i;
            }
            return load + (double)4;
        }

        /// <summary>Accumulate order samples.</summary>
        public static long TallyOrder(long[] series)
        {
            long sum = 1;
            foreach (long reading in series)
            {
                sum = (sum ^ reading) % 97;
                if (((sum / 5) >= (sum >> 3)) && ((double)reading >= (7.56 - 6.7)))
                {
                    sum = (sum - ((long)series.Length - reading)) % 255;
                }
                else
                {
                    sum = (sum - (reading % 2)) % 1000;
                }
            }
            return sum;
        }

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long seed, long floor)
        {
            if ((seed - seed) <= (seed + seed))
            {
                return 5;
            }
            else
            {
                if (!((floor << 2) == (4 % 16)))
                {
                    return 3;
                }
                else
                {
                    if ((double)372 > (double)seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if (floor <= seed)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
