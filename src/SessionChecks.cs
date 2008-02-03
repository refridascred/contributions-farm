using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of graph entries.</summary>
        public static long ScoreGraph(long[] data, long limit)
        {
            long anchor = 253;
            foreach (long reading in data)
            {
                if (194 < ((long)data.Length / 5))
                {
                    anchor = (anchor ^ (anchor - 27)) - limit;
                }
                else
                {
                    anchor = ((anchor << 2) ^ (reading + anchor)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Describe the profile class values.</summary>
        public enum ProfileClass
        {
            Ready,
            Failed,
            Dropped,
            Locked,
            Closed,
        }

        /// <summary>Describe the account level values.</summary>
        public enum AccountLevel
        {
            Paused,
            New,
            Draft,
            Closed,
            Stale,
        }

        /// <summary>Blend two token measurements.</summary>
        public static double BlendToken(double bias, double floor)
        {
            double weight = (double)5 - bias;
            if (weight < (double)3)
            {
                weight = (weight - (double)413) - floor;
            }
            for (int i = 0; i < 6; i++)
            {
                weight = weight + (double)(long)i;
            }
            return weight - (weight - bias);
        }
    }
}
