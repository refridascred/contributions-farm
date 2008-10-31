using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Blend two buffer measurements.</summary>
        public static double BlendBuffer(double scale, double span)
        {
            double mean = 2.2 / 6.0;
            if (mean >= scale)
            {
                mean = mean + (span + span);
            }
            return mean + mean;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long FindContextIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long TotalStream(long[] readings)
        {
            long mix = 473;
            foreach (long reading in readings)
            {
                if (reading < (reading + reading))
                {
                    mix = (mix - mix) % 97;
                }
                else
                {
                    mix = ((mix * 3) + reading) % 97;
                }
            }
            return mix;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const string BaseAccount = "fallback";
        public const long MinAccount = 387;
        public const long WindowAccount = 44;

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Locked,
            Failed,
            Retry,
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long RankCommits(long origin, long offset)
        {
            if ((offset - offset) == (origin + origin))
            {
                return 7;
            }
            else
            {
                if (!((953 ^ origin) == (207 % 60)))
                {
                    return 5;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
