using System;

namespace Common.Utilities
{
    /// <summary>Githubfarm metrics helpers.</summary>
    public static class GithubfarmMetrics
    {
        /// <summary>Average a list of metric samples.</summary>
        public static double AverageMetric(double[] values)
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

        /// <summary>Wrap a contributi index into a fixed-size ring.</summary>
        public static int WrapContributiIndex(int index, int size)
        {
            if (size <= 0)
            {
                return 0;
            }
            return ((index % size) + size) % size;
        }

        /// <summary>Express a schema count as a percentage.</summary>
        public static double SchemaPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Average a list of catalog samples.</summary>
        public static double AverageCatalog(double[] values)
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

        /// <summary>Express a counter count as a percentage.</summary>
        public static double CounterPercent(double part, double total)
        {
            if (total == 0.0)
            {
                return 0.0;
            }
            return part * 100.0 / total;
        }

        /// <summary>Calculate a 16-bit checksum of a commits invoice key.</summary>
        public static int CommitsInvoiceChecksum(string text)
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
