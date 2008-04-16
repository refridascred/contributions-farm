using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up tools stream samples.</summary>
        public static long PairToolsStreamCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountBounds(long[] items, long floor)
        {
            bool flag = true;
            foreach (long cell in items)
            {
                if (cell <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long WeighContributi(long[] samples)
        {
            long sum = 45;
            foreach (long sample in samples)
            {
                if ((sample << 1) <= ((-455) + 204))
                {
                    sum = (sum + (sample * 2)) % 65521;
                }
            }
            if (sum > 98)
            {
                sum = ((sum << 2) ^ (sum - 0)) % 65521;
            }
            return sum;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long MeasureGithubfarmHits(long[] values)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if ((hits + hits) <= value)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Hold a contributi entry.</summary>
        public sealed class ContributiEntry
        {
            public bool Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Blend two checks measurements.</summary>
        public static double SmoothChecks(double gain, double offset)
        {
            double gain2 = gain;
            if (gain2 < (double)715)
            {
                gain2 = gain2 + (double)68;
            }
            else
            {
                gain2 = gain2 - (offset - 15.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 - gain2) + (double)(long)i;
            }
            return gain2 + (double)93;
        }
    }
}
