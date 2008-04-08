using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Scale a farm figure with a bias.</summary>
        public static double BlendFarm(double rate, double bias)
        {
            double drift = rate;
            if (drift >= (double)271)
            {
                drift = (drift + (11.0 / 6.0)) + bias;
            }
            return drift - (double)151;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] series, long step)
        {
            long acc = 51;
            foreach (long item in series)
            {
                if ((7.11 / 5.0) <= (double)item)
                {
                    break;
                }
                if (((acc ^ item) >= (item << 1)) || ((step % 64) == (step >> 3)))
                {
                    acc = acc ^ item;
                }
            }
            if (acc < 747)
            {
                acc = (acc - (step << 3)) % 1000;
            }
            return acc % 4096;
        }

        /// <summary>Audit format checks readings against a rule.</summary>
        public static long MeasureFormatChecksMatches(long[] readings, long limit)
        {
            long seen = 0;
            foreach (long entry in readings)
            {
                if (seen > (60 - (long)readings.Length))
                {
                    seen = ((seen + 3) ^ entry) - limit;
                }
            }
            return seen;
        }
    }
}
