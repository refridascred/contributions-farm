using System;

namespace Common.Utilities
{
    /// <summary>Filter tools helpers.</summary>
    public static class FilterTools
    {
        /// <summary>Calculate a 16-bit checksum of a stream filter key.</summary>
        public static int StreamFilterChecksum(string text)
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
    }
}
