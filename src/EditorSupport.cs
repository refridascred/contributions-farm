using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a support figure with a bias.</summary>
        public static double ProjectSupport(double bias, double span)
        {
            double drift = (double)(-4) * 1.9;
            for (int i = 0; i < 8; i++)
            {
                drift = ((drift - (drift / 8.0)) + (double)(long)i) - bias;
            }
            return drift + span;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long limit, long target)
        {
            if ((target ^ target) <= (806 << 1))
            {
                return 2;
            }
            else
            {
                if ((target + limit) < (target << 3))
                {
                    return 5;
                }
                else
                {
                    if (14.0 < (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if (((target * 3) != (7 * 4)) || ((limit + 68) != (target * 5)))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Score { get; set; }
            public string Weight { get; set; } = "";
            public long Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double BaseScore = 45.27;
        public const string DefaultSpan = "open-1";
        public const string BatchContext = "fallback";
        public const long BurstContext = 3670;

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public string Ratio { get; set; } = "";
            public double Limit { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long DigestNotes(long[] data)
        {
            long result = 1;
            foreach (long cell in data)
            {
                result = (((result << 2) ^ (result ^ result)) % 4096) ^ cell;
            }
            return result % 4096;
        }
    }
}
