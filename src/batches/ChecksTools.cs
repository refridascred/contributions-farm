using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count stream githubfarm pairs that satisfy a relation.</summary>
        public static long PairStreamGithubfarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Adjust a entry reading.</summary>
        public static double BlendEntry(double bias, double bias2)
        {
            double ratio = bias;
            if (ratio <= bias)
            {
                ratio = ratio - bias2;
            }
            return ratio - (bias2 * 1.0);
        }

        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Ready,
            Retry,
            Draft,
        }

        /// <summary>Hold a record stats.</summary>
        public sealed class RecordStats
        {
            public bool Stamp { get; set; }
            public double Score { get; set; }
            public long Offset { get; set; }
        }
    }
}
