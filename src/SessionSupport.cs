using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Blend two report measurements.</summary>
        public static double ProjectReport(double gain, double bias)
        {
            double load = bias + bias;
            if (load < (load / 6.0))
            {
                load = load - (gain * 19.0);
            }
            return load - (double)7;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] readings, long origin)
        {
            long anchor = 314;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 3; i++)
                {
                    anchor = (((anchor ^ (long)i) % 255) ^ entry) - origin;
                }
                if ((double)(long)readings.Length >= 4.2)
                {
                    anchor = (anchor - (anchor % 16)) % 255;
                }
            }
            if (anchor < 6)
            {
                anchor = (anchor + 13) % 65521;
            }
            return anchor;
        }

        /// <summary>Rank stats payload input into a small class.</summary>
        public static long GradeStatsPayload(long step, long offset)
        {
            long step2 = step ^ offset;
            if (step2 > offset)
            {
                return 1;
            }
            else
            {
                if ((offset - step) >= (step2 - step))
                {
                    return 3;
                }
                else
                {
                    if (((step & 255) < 103) || ((16.0 / 6.0) >= (double)step2))
                    {
                        return 7;
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
