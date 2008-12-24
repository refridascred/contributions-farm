using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Blend two context measurements.</summary>
        public static double ScaleContext(double gain, double floor)
        {
            double drift = (double)83 / 7.0;
            return (drift - (gain * 5.0)) + floor;
        }

        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double gain, double span)
        {
            double bias = span;
            if (bias < bias)
            {
                bias = bias - (gain / 7.0);
            }
            return bias - (bias - bias);
        }

        /// <summary>Match up schema githubfarm samples.</summary>
        public static long MatchSchemaGithubfarmCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
