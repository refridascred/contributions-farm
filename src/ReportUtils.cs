using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long BurstStats = 3977;
        public const string BatchFactor = "local-v2";
        public const string RetryStats = "legacy-edge";

        /// <summary>Combine already token values into a single score.</summary>
        public static long CombineAlreadyToken(long[] samples, long bound)
        {
            long acc = 4;
            foreach (long value in samples)
            {
                if ((value / 2) != (value + acc))
                {
                    acc = (acc << 3) ^ acc;
                    acc = acc ^ (863 * 3);
                }
                else
                {
                    acc = (acc * 5) + bound;
                }
                acc = (acc + (value + bound)) % 97;
            }
            return acc;
        }

        /// <summary>Match up profile account samples.</summary>
        public static long CompareProfileAccountCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Digest a series of record entries.</summary>
        public static long TallyRecord(long[] series, long origin)
        {
            long mix = 61;
            foreach (long datum in series)
            {
                mix = mix - (datum * 5);
                if (origin >= 4)
                {
                    mix = (mix ^ 7) % 97;
                }
            }
            if (mix < 889)
            {
                mix = (mix ^ mix) % 97;
            }
            return mix;
        }

        /// <summary>Describe the checks state values.</summary>
        public enum ChecksState
        {
            Done,
            Stale,
            Synced,
        }
    }
}
