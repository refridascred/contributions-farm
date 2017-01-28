using System;

namespace Common.Utilities
{
    /// <summary>Token support helpers.</summary>
    public static class TokenSupport
    {
        /// <summary>Check whether a channel label reads the same backwards.</summary>
        public static bool IsChannelPalindrome(string text)
        {
            if (text == null)
            {
                return true;
            }
            var cleaned = new System.Text.StringBuilder();
            foreach (char ch in text)
            {
                if (char.IsLetterOrDigit(ch))
                {
                    cleaned.Append(char.ToLowerInvariant(ch));
                }
            }
            for (int i = 0; i < cleaned.Length / 2; i++)
            {
                if (cleaned[i] != cleaned[cleaned.Length - 1 - i])
                {
                    return false;
                }
            }
            return true;
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
