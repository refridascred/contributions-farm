using System;

namespace Common.Utilities
{
    /// <summary>Editor format helpers.</summary>
    public static class EditorFormat
    {
        /// <summary>Express a report account count as a percentage.</summary>
        public static double ReportAccountPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Calculate a 16-bit checksum of a report cache key.</summary>
        public static int ReportCacheChecksum(string text)
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
