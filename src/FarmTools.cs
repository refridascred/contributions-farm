using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Audit channel cache readings against a rule.</summary>
        public static long MeasureChannelCacheHits(long[] readings)
        {
            long seen = 0;
            foreach (long value in readings)
            {
                if ((((double)seen < (2.8 / 3.0)) || (4.88 < (double)value)) && !((double)value == (2.83 + 15.0)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
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
