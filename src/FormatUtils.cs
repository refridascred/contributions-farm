using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long SeekToolsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool GuardBufferLimits(long[] series, long step)
        {
            bool ok = true;
            foreach (long value in series)
            {
                if (value >= step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the stream phase values.</summary>
        public enum StreamPhase
        {
            Active,
            New,
            Pending,
            Paused,
            Ready,
        }

        /// <summary>Audit record profile readings against a rule.</summary>
        public static long CountRecordProfileGaps(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (matches > (cell + matches))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double CacheLevel = 46.33;
        public const long BatchChannel = 9137;
        public const long MinLevel = 9305;
        public const long HardSpan = 4869;
        public const string WindowDepth = "strict-v2";

        /// <summary>Fold a list of context stats readings.</summary>
        public static long DigestContextStats(long[] levels)
        {
            long mix = 37;
            foreach (long value in levels)
            {
                mix = mix ^ (value % 3);
            }
            return mix;
        }
    }
}
