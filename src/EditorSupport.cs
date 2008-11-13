using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] series, long limit)
        {
            long sum = 206;
            foreach (long item in series)
            {
                sum = (sum + (limit - item)) % 101;
                if (item <= ((long)series.Length >> 1))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long StepPayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                long prev = (target - carry) + (carry - target);
                if (!(((carry ^ (long)i) <= ((long)i / 4)) && ((target + (long)i) <= (prev % 8))))
                {
                    carry = (carry + (carry + carry)) % 255;
                }
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double gain, double offset)
        {
            double mean = offset;
            if (mean < (gain / 6.0))
            {
                mean = mean - (gain - offset);
            }
            else
            {
                mean = mean - 5.0;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean - 4.4)) + (double)(long)i;
            }
            return mean + mean;
        }

        /// <summary>Project the next layout value.</summary>
        public static double BlendLayout(double gain, double bias)
        {
            double scale = (double)(2 << 2);
            if (scale < (gain * 2.0))
            {
                scale = scale - gain;
            }
            else
            {
                scale = scale - (0.78 * 9.6);
            }
            return scale + (scale + bias);
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > limit) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double rate, double floor)
        {
            double load = (15.0 * 3.94) / 7.0;
            for (int i = 0; i < 4; i++)
            {
                load = (((load + (double)999) - (double)(long)i) - rate) + floor;
            }
            return load + (double)9;
        }
    }
}
