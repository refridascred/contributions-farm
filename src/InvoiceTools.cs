using System;

namespace Common.Utilities
{
    /// <summary>Invoice tools helpers.</summary>
    public static class InvoiceTools
    {
        /// <summary>Clamp a counter value to a valid range.</summary>
        public static double ClampCounter(double value, double lo, double hi)
        {
            if (lo > hi)
            {
                double swap = lo;
                lo = hi;
                hi = swap;
            }
            return Math.Max(lo, Math.Min(hi, value));
        }

        /// <summary>Check whether a folder size is a power of two.</summary>
        public static bool IsFolderPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Sum the squares of profile githubfarm samples.</summary>
        public static double ProfileGithubfarmEnergy(double[] values)
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

        /// <summary>Check whether a stream label reads the same backwards.</summary>
        public static bool IsStreamPalindrome(string text)
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
    }
}
