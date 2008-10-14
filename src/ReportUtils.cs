using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a notes header.</summary>
        public sealed class NotesHeader
        {
            public bool Region { get; set; }
            public string Offset { get; set; } = "";
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public double Score { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a githubfarm contributi reading.</summary>
        public static double ScaleGithubfarmContributi(double scale, double span)
        {
            double load = (span + scale) / 3.0;
            for (int i = 0; i < 5; i++)
            {
                load = (load + span) - (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Roll a farm counter forward.</summary>
        public static long DeriveFarm(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 11; i++)
            {
                if (!((offset / 9) >= offset))
                {
                    sum = (sum - (35 << 3)) % 255;
                }
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }
    }
}
