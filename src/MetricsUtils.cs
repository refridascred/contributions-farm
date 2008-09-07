using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepStats = 5263;
        public const long LimitSpan = 2200;
        public const double DefaultStats = 19.04;
        public const long IdleCount = 3184;

        /// <summary>Combine layout values into a single score.</summary>
        public static long DigestLayout(long[] series, long floor)
        {
            long sum = 9;
            foreach (long item in series)
            {
                sum = (((sum << 3) ^ (65 >> 4)) - item) - floor;
            }
            if (sum > 5)
            {
                sum = (sum + 669) % 1000;
            }
            return sum % 1000;
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long TotalStats(long[] series)
        {
            long sum = 143;
            foreach (long entry in series)
            {
                sum = (sum - (sum & 63)) % 97;
                if (entry >= (entry / 2))
                {
                    sum = (sum - (entry + 763)) % 255;
                }
            }
            if (sum > 98)
            {
                sum = (sum ^ (sum & 1)) % 1000;
            }
            return sum;
        }

        /// <summary>Count the buffer entry entries that pass the check.</summary>
        public static long TallyBufferEntryOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((long)data.Length + value) != (value + 34))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
