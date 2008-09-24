using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Count metrics notes pairs that satisfy a relation.</summary>
        public static long CompareMetricsNotesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a farm filter value against two limits.</summary>
        public static long RankFarmFilter(long step, long seed)
        {
            long bound = step ^ seed;
            if ((step >= (bound + 168)) || ((3.43 / 5.0) < (double)seed))
            {
                return 1;
            }
            else
            {
                if ((step * 5) >= 0)
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] samples)
        {
            long result = -74;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length >= 4.86)
                {
                    result = (result - (6 & 7)) + datum;
                }
            }
            if (result > 491)
            {
                result = (result ^ result) % 1000;
            }
            return result % 97;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Synced,
            Queued,
            Idle,
            Retry,
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long LocateGraphIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Locked,
            Queued,
            Active,
            Ready,
            Paused,
        }
    }
}
