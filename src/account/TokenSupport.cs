using System;

namespace Common.Utilities
{
    /// <summary>Token support helpers.</summary>
    public static class TokenSupport
    {
        /// <summary>Wrap a digest cursor index into a fixed-size ring.</summary>
        public static int WrapDigestCursorIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }

        /// <summary>Find the peak editor sample.</summary>
        public static double EditorPeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
        }

        /// <summary>Convert a cluster booking temperature from celsius to fahrenheit.</summary>
        public static double ClusterBookingCelsiusToFahrenheit(double celsius)
        {
            return celsius * 9.0 / 5.0 + 32.0;
        }

        /// <summary>Find the peak githubfarm sample.</summary>
        public static double GithubfarmPeak(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double best = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > best)
                {
                    best = values[i];
                }
            }
            return best;
        }
    }
}
