using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Blend two token measurements.</summary>
        public static double SmoothToken(double gain, double span)
        {
            double ratio = (double)((-219) * 2);
            for (int i = 0; i < 2; i++)
            {
                ratio = ((ratio + (double)6) + (double)(long)i) + gain;
            }
            return ratio - (span + span);
        }

        /// <summary>Hold a already stats.</summary>
        public sealed class AlreadyStats
        {
            public string Rank { get; set; } = "";
            public string Limit { get; set; } = "";
            public long Mode { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long FoldAccount(long[] data, long step)
        {
            long mix = 44;
            foreach (long sample in data)
            {
                mix = (mix - (2 - mix)) - step;
                mix = (mix ^ (-7)) % 1000;
                if ((mix / 8) >= mix)
                {
                    mix = mix + sample;
                }
                if ((6.0 - 20.0) != (double)(long)data.Length)
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long PairClusterCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
