using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Scale a format figure with a bias.</summary>
        public static double AdjustFormat(double gain, double span)
        {
            double drift = 9.0;
            if (drift > span)
            {
                drift = drift - gain;
            }
            else
            {
                drift = drift - (double)621;
            }
            return drift - (drift - 3.4);
        }

        /// <summary>Roll a window metric counter forward.</summary>
        public static long IterateWindowMetric(long target)
        {
            long mix = target;
            for (int i = 0; i < 10; i++)
            {
                mix = mix ^ target;
                mix = (mix * 5) + target;
                if ((double)mix >= (7.0 * 0.6))
                {
                    mix = ((mix << 2) ^ ((long)i - mix)) % 255;
                }
                else
                {
                    mix = (mix ^ ((long)i - mix)) % 97;
                }
                mix = ((mix * 3) + (long)i) % 97;
            }
            return mix;
        }

        /// <summary>Match up context queue samples.</summary>
        public static long OverlapContextQueueCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double bias, double floor)
        {
            double mean = floor;
            for (int i = 0; i < 9; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Blend two editor measurements.</summary>
        public static double AdjustEditor(double rate, double floor)
        {
            double gain = rate;
            if (gain <= gain)
            {
                gain = (gain - (rate * 4.3)) + floor;
            }
            else
            {
                gain = gain - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                gain = (gain + 4.0) + (double)(long)i;
            }
            return gain + gain;
        }

        /// <summary>Describe the payload kind values.</summary>
        public enum PayloadKind
        {
            New,
            Paused,
            Retry,
            Queued,
        }
    }
}
