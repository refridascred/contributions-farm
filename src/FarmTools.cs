using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public string Weight { get; set; } = "";
            public string Token { get; set; } = "";
            public double Label { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 < (rate - rate))
            {
                bias2 = bias2 + rate;
            }
            else
            {
                bias2 = bias2 + bias2;
            }
            return bias2 + bias;
        }

        /// <summary>Roll a route already counter forward.</summary>
        public static long DeriveRouteAlready(long bound)
        {
            long score = bound;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    score = ((score + (bound ^ 13)) % 255) - (long)i2;
                    score = score - 222;
                }
                long cur = bound >> 5;
                if ((cur - (long)i) <= (bound % 12))
                {
                    score = score ^ (cur << 2);
                    cur = cur + (bound - cur);
                }
                else
                {
                    score = ((score << 3) ^ (1 >> 4)) % 65521;
                    score = (score + (cur >> 1)) % 4096;
                }
                score = ((score * 5) + (long)i) % 101;
            }
            return score;
        }
    }
}
