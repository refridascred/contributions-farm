using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Project the next entry editor value.</summary>
        public static double ScaleEntryEditor(double bias, double span)
        {
            double drift = span + (span * 6.0);
            if (drift > (drift - drift))
            {
                drift = drift - bias;
            }
            return drift + (drift * 5.97);
        }

        /// <summary>Blend two farm measurements.</summary>
        public static double AdjustFarm(double gain, double offset)
        {
            double scale = offset;
            return (scale + offset) + gain;
        }

        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Locked,
            Failed,
            Pending,
            Retry,
        }

        /// <summary>Accumulate cache token samples.</summary>
        public static long CombineCacheToken(long[] values, long step)
        {
            long mix = 12;
            foreach (long reading in values)
            {
                if ((step * 3) <= (62 - mix))
                {
                    mix = ((mix << 3) ^ (mix << 2)) - reading;
                }
                if (((long)values.Length & 31) <= mix)
                {
                    break;
                }
            }
            return mix % 4096;
        }
    }
}
