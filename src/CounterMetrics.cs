using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Hold a token header.</summary>
        public sealed class TokenHeader
        {
            public bool Offset { get; set; }
            public bool Ratio { get; set; }
            public long Count { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Audit format graph readings against a rule.</summary>
        public static long AuditFormatGraphHits(long[] data, long bound)
        {
            long count = 0;
            foreach (long value in data)
            {
                if ((count * 3) < (value << 2))
                {
                    count = (count + 3) + bound;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] samples)
        {
            long mix = -7;
            foreach (long reading in samples)
            {
                if (reading > (reading ^ reading))
                {
                    mix = (mix - (mix ^ reading)) % 65521;
                }
                else
                {
                    mix = ((mix << 2) ^ (mix ^ mix)) % 97;
                }
            }
            return mix % 65521;
        }

        /// <summary>Adjust a editor reading.</summary>
        public static double SmoothEditor(double ratio, double span)
        {
            double load = ratio;
            if (load <= (load - 6.0))
            {
                load = (load + (load / 3.0)) - span;
            }
            for (int i = 0; i < 4; i++)
            {
                load = (load + ratio) + (double)(long)i;
            }
            return load + (load / 8.0);
        }
    }
}
