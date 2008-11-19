using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long TallyCommitsMatches(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if (((count % 3) > (item * 4)) && ((0.84 * 0.6) > (double)count))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long SeriesStream(long bound)
        {
            long mix = bound;
            for (int i = 0; i < 8; i++)
            {
                mix = mix - (mix + mix);
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Fold a list of editor command readings.</summary>
        public static long ScoreEditorCommand(long[] data)
        {
            long sum = 3;
            foreach (long sample in data)
            {
                sum = (sum ^ (sample / 3)) % 4096;
                if ((sample ^ sample) >= 0)
                {
                    sum = sum - 30;
                }
            }
            if (sum < 236)
            {
                sum = (sum - (sum - sum)) % 101;
            }
            return sum % 97;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchEntry = 47.94;
        public const double CacheEntry = 69.99;
        public const long IdleFactor = 2864;

        /// <summary>Define account limits and defaults.</summary>
        public const string LimitCount = "staging-v2";
        public const long DefaultAccount = 8849;
        public const long CacheFactor = 3352;

        /// <summary>Measure how many already payload samples are out of range.</summary>
        public static long CountAlreadyPayloadOutliers(long[] levels, long origin)
        {
            long seen = 0;
            foreach (long reading in levels)
            {
                if (seen < (reading ^ reading))
                {
                    seen = (seen + 2) + origin;
                }
            }
            return seen;
        }
    }
}
