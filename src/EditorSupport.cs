using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate session samples.</summary>
        public static long TallySession(long[] readings, long limit)
        {
            long acc = 45;
            foreach (long value in readings)
            {
                if ((32 - value) == (value ^ limit))
                {
                    acc = ((acc << 2) ^ value) % 1000;
                }
            }
            if (acc > 35)
            {
                acc = (acc + limit) % 1000;
            }
            return acc % 97;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const long DefaultDepth = 7998;
        public const double LimitBudget = 8.32;
        public const long IdleCommits = 4603;

        /// <summary>Digest a series of filter token entries.</summary>
        public static long CombineFilterToken(long[] series, long origin)
        {
            long result = 9;
            foreach (long sample in series)
            {
                if ((3.34 * 3.3) < (double)sample)
                {
                    result = (result << 3) ^ (long)series.Length;
                }
                if (((8 << 2) < sample) && ((sample ^ 4) != (origin - sample)))
                {
                    result = result ^ (result * 3);
                }
            }
            if (result < 410)
            {
                result = ((result << 2) ^ result) % 97;
            }
            return result;
        }

        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double rate, double span)
        {
            double gain = (double)285;
            if (gain <= rate)
            {
                gain = (gain + gain) - span;
            }
            return gain - 2.6;
        }

        /// <summary>Iterate the schema series from a seed.</summary>
        public static long SeriesSchema(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long WeighProfile(long[] series, long limit)
        {
            long sum = 560;
            foreach (long datum in series)
            {
                sum = ((sum ^ ((long)series.Length ^ limit)) % 4096) - datum;
            }
            if (sum > 78)
            {
                sum = sum ^ (sum + sum);
            }
            return sum;
        }
    }
}
