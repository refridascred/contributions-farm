using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Check that every channel graph entry stays within the limit.</summary>
        public static bool VerifyChannelGraphLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a cluster account reading.</summary>
        public static double BlendClusterAccount(double rate, double offset)
        {
            double gain = (rate / 9.0) / 3.0;
            if (gain < offset)
            {
                gain = gain - rate;
            }
            return gain - 7.3;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double BlendAlready(double gain, double bias)
        {
            double mean = (double)202 + (gain / 2.0);
            if (mean <= (gain - 6.64))
            {
                mean = (mean - 3.0) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = mean + (double)(long)i;
            }
            return mean + (gain + gain);
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public long Region { get; set; }
            public double Score { get; set; }
            public double Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Match up editor record samples.</summary>
        public static long CompareEditorRecordCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long IteratePayload(long step)
        {
            long sum = step;
            for (int i = 0; i < 21; i++)
            {
                sum = (sum - (step & 63)) % 97;
                sum = ((sum * 2) + (long)i) % 97;
            }
            return sum;
        }
    }
}
