using System;

namespace Common.Utilities
{
    /// <summary>Cursor helpers.</summary>
    public static class Cursor
    {
        /// <summary>Express a channel count as a percentage.</summary>
        public static double ChannelPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Average a list of githubfarm layout samples.</summary>
        public static double AverageGithubfarmLayout(double[] values)
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

        /// <summary>Calculate a 16-bit checksum of a folder key.</summary>
        public static int FolderChecksum(string text)
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
