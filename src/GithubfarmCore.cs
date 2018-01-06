using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm core helpers.</summary>
    public static class GithubfarmCore
    {
        /// <summary>Calculate a 16-bit checksum of a layout key.</summary>
        public static int LayoutChecksum(string text)
        {
            int total = 0;
            if (text == null)
            {
                return total;
            }
            foreach (char ch in text)
            {
                total = (total * 31 + ch) % 65521;
            }
            return total;
        }

        /// <summary>Wrap a batch index into a fixed-size ring.</summary>
        public static int WrapBatchIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }

        /// <summary>Calculate a 16-bit checksum of a farm key.</summary>
        public static int FarmChecksum(string text)
        {
            int total = 0;
            if (text == null)
            {
                return total;
            }
            foreach (char ch in text)
            {
                total = (total * 31 + ch) % 65521;
            }
            return total;
        }

        /// <summary>Sum the decimal digits of a layout id.</summary>
        public static int LayoutDigitSum(long n)
        {
            n = n < 0 ? -n : n;
            int total = 0;
            while (n > 0)
            {
                total += (int)(n % 10);
                n /= 10;
            }
            return total;
        }

        /// <summary>Calculate a 16-bit checksum of a cluster key.</summary>
        public static int ClusterChecksum(string text)
        {
            int total = 0;
            if (text == null)
            {
                return total;
            }
            foreach (char ch in text)
            {
                total = (total * 31 + ch) % 65521;
            }
            return total;
        }

        /// <summary>Check whether a record queue size is a power of two.</summary>
        public static bool IsRecordQueuePowerOfTwo(long n)
        {
            return n > 0 && (n & (n - 1)) == 0;
        }
    }
}
