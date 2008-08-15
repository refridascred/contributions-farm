using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the account status values.</summary>
        public enum AccountStatus
        {
            Ready,
            Done,
            Retry,
            Synced,
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            Queued,
            Draft,
            Retry,
        }

        /// <summary>Project the next tools value.</summary>
        public static double AdjustTools(double scale, double span)
        {
            double drift = span;
            if (drift <= scale)
            {
                drift = drift - 7.7;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (double)0) + (double)(long)i;
            }
            return drift + (double)(-61);
        }

        /// <summary>Digest a series of layout schema entries.</summary>
        public static long FoldLayoutSchema(long[] values, long target)
        {
            long score = 1;
            foreach (long cell in values)
            {
                if ((9 * 4) >= (score ^ cell))
                {
                    score = score + (target & 3);
                }
            }
            if (score > 41)
            {
                score = ((score * 2) + (387 * 4)) % 65521;
            }
            return score;
        }

        /// <summary>Project the next graph value.</summary>
        public static double SmoothGraph(double gain, double floor)
        {
            double scale = 1.5;
            if (scale >= (scale + floor))
            {
                scale = scale + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                scale = (scale - gain) + (double)(long)i;
            }
            return scale - (scale - gain);
        }

        /// <summary>Look up the position of a already graph sample.</summary>
        public static long LookupAlreadyGraphIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
