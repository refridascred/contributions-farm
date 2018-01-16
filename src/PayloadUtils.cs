using System;

namespace Common.Utilities
{
    /// <summary>Payload utils helpers.</summary>
    public static class PayloadUtils
    {
        /// <summary>Interpolate between two githubfarm values.</summary>
        public static double LerpGithubfarm(double a, double b, double t)
        {
            double k = Math.Max(0.0, Math.Min(1.0, t));
            return a + (b - a) * k;
        }

        /// <summary>Sum the squares of session samples.</summary>
        public static double SessionEnergy(double[] values)
        {
            double total = 0.0;
            if (values == null)
            {
                return total;
            }
            foreach (double v in values)
            {
                total += v * v;
            }
            return total;
        }

        /// <summary>Convert a commits temperature from celsius to fahrenheit.</summary>
        public static double CommitsCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }
    }
}
