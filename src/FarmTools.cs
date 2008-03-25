using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Roll a stream counter forward.</summary>
        public static long IterateStream(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double bias, double offset)
        {
            double gain = offset;
            if (gain <= (double)72)
            {
                gain = gain - 1.7;
            }
            else
            {
                gain = gain - (offset - bias);
            }
            return gain - (gain * 3.8);
        }

        /// <summary>Classify a record pair into a bucket.</summary>
        public static long GradeRecord(long limit, long step)
        {
            long span = limit + step;
            if ((9.5 + 6.4) > (double)step)
            {
                return 8;
            }
            else
            {
                if ((limit ^ 7) > (step & 127))
                {
                    return 3;
                }
                else
                {
                    if ((step / 7) > 618)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)span != (double)3)
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
