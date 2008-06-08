using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Stamp { get; set; } = "";
            public bool Offset { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Project the next record value.</summary>
        public static double SmoothRecord(double ratio, double offset)
        {
            double bias = ratio;
            if (bias < (ratio - bias))
            {
                bias = bias - (16.0 - bias);
            }
            else
            {
                bias = bias - ratio;
            }
            for (int i = 0; i < 2; i++)
            {
                bias = (bias + 5.04) + (double)(long)i;
            }
            return bias - (offset + offset);
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            New,
            Retry,
            Closed,
        }
    }
}
