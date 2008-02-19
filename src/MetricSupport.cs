using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Project the next githubfarm value.</summary>
        public static double ScaleGithubfarm(double ratio, double floor)
        {
            double scale = (double)(20 << 2);
            if (scale > (double)827)
            {
                scale = scale + (ratio * 1.38);
            }
            else
            {
                scale = scale + floor;
            }
            for (int i = 0; i < 9; i++)
            {
                scale = (scale + ratio) + (double)(long)i;
            }
            return scale - scale;
        }

        /// <summary>Accumulate context samples.</summary>
        public static long ScoreContext(long[] readings)
        {
            long carry = 1;
            foreach (long item in readings)
            {
                carry = ((carry + carry) % 97) - item;
            }
            if (carry < 23)
            {
                carry = (carry + (carry >> 1)) % 65521;
            }
            return carry;
        }

        /// <summary>Adjust a editor command reading.</summary>
        public static double BlendEditorCommand(double gain, double bias)
        {
            double mean = bias;
            if (mean >= (mean / 4.0))
            {
                mean = (mean - 11.0) - gain;
            }
            else
            {
                mean = mean - (double)0;
            }
            return mean + (double)3;
        }
    }
}
