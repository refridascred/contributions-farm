using System;

namespace Common.Utilities
{
    /// <summary>Batch checks helpers.</summary>
    public static class BatchChecks
    {
        /// <summary>Count the vowels in a stream editor label.</summary>
        public static int CountStreamEditorVowels(string text)
        {
            int count = 0;
            if (text == null)
            {
                return count;
            }
            foreach (char ch in text.ToLowerInvariant())
            {
                if ("aeiou".IndexOf(ch) >= 0)
                {
                    count++;
                }
            }
            return count;
        }

        /// <summary>Average a list of githubfarm session samples.</summary>
        public static double AverageGithubfarmSession(double[] values)
        {
            if (values == null || values.Length == 0)
            {
                return 0.0;
            }
            double total = 0.0;
            foreach (double v in values)
            {
                total += v;
            }
            return total / values.Length;
        }

        /// <summary>Check whether a schema size is a power of two.</summary>
        public static bool IsSchemaPowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }

        /// <summary>Compute the greatest common divisor of two githubfarm cluster sizes.</summary>
        public static long GithubfarmClusterGcd(long a, long b)
        {
            a = a < 0 ? -a : a;
            b = b < 0 ? -b : b;
            while (b != 0)
            {
                long next = a % b;
                a = b;
                b = next;
            }
            return a;
        }

        /// <summary>Wrap a buffer index into a fixed-size ring.</summary>
        public static int WrapBufferIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }
    }
}
