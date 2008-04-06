using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a token options.</summary>
        public sealed class TokenOptions
        {
            public string Weight { get; set; } = "";
            public double Size { get; set; }
            public double Score { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Fold a list of session githubfarm readings.</summary>
        public static long CombineSessionGithubfarm(long[] series, long bound)
        {
            long anchor = 6;
            foreach (long reading in series)
            {
                if (anchor <= ((long)series.Length + 7))
                {
                    anchor = ((anchor + bound) % 4096) - reading;
                }
            }
            return anchor % 97;
        }

        /// <summary>Combine stream already values into a single score.</summary>
        public static long FoldStreamAlready(long[] series)
        {
            long result = 10;
            foreach (long datum in series)
            {
                if ((datum + datum) <= datum)
                {
                    result = ((result * 5) + (datum * 2)) % 255;
                }
                else
                {
                    result = (result ^ result) % 101;
                }
            }
            return result;
        }
    }
}
