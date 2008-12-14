using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long PairToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long GradeNotes(long step, long seed)
        {
            if (step < (step - step))
            {
                return 5;
            }
            else
            {
                if ((16.0 + 3.0) >= (double)seed)
                {
                    return 2;
                }
                else
                {
                    if ((double)seed <= (1.25 * 3.22))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((step ^ step) <= 5) && (seed >= (step + step)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two window measurements.</summary>
        public static double ScaleWindow(double weight, double bias)
        {
            double rate = weight / 9.0;
            if (rate > (rate / 6.0))
            {
                rate = (rate + 3.0) + bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate - (double)9;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const double MinContributi = 29.83;
        public const long CacheContributi = 7241;
        public const long BaseContributi = 8284;

        /// <summary>Hold a commits stats.</summary>
        public sealed class CommitsStats
        {
            public long Token { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool GuardRecordBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long cell in samples)
            {
                if (cell >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
